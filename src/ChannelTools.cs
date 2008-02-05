using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate order queue samples.</summary>
        public static long ScoreOrderQueue(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                if (((long)samples.Length - value) >= total)
                {
                    total = ((total << 3) ^ total) % 4096;
                    total = (total * 5) + ((long)samples.Length + 2);
                }
                if ((total / 5) != ((-228) - 0))
                {
                    total = (total << 3) ^ (value / 6);
                }
                if ((double)total == (6.58 + 8.0))
                {
                    total = ((total * 2) + (99 % 7)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total ^ value);
                }
            }
            return total;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
