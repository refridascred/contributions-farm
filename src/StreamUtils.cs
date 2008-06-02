using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if ((double)(-7) < 5.56)
                {
                    anchor = ((anchor << 2) ^ (datum & 63)) % 101;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Project the next farm profile value.</summary>
        public static double BlendFarmProfile(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (bias * 1.71))
            {
                mean = mean + (9.34 - ratio);
            }
            else
            {
                mean = mean - (double)9;
            }
            return mean - ratio;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
