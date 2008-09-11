using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Validate profile support readings against a bound.</summary>
        public static bool ValidateProfileSupportLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items, long target)
        {
            long total = 993;
            foreach (long item in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 2) ^ (target & 3)) % 1000) ^ (long)i;
                    total = (total ^ (target + total)) % 255;
                }
                total = (total + (target - 6)) % 4096;
                if ((item - target) <= ((-712) - total))
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = (total ^ (item / 2)) % 255;
                }
            }
            if (total > 4)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Accumulate stream command samples.</summary>
        public static long TallyStreamCommand(long[] data)
        {
            long state = 0;
            foreach (long entry in data)
            {
                state = (state + entry) % 65521;
            }
            if (state > 755)
            {
                state = ((state << 3) ^ (state ^ state)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
