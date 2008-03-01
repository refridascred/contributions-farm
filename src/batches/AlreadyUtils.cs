using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two contributi filter measurements.</summary>
        public static double AdjustContributiFilter(double rate, double bias)
        {
            double bias2 = (double)(-30) - (double)89;
            if (bias2 < (rate * 5.5))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + rate;
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long TotalSupportStats(long[] series, long offset)
        {
            long anchor = 818;
            foreach (long value in series)
            {
                if ((anchor + anchor) <= (offset / 6))
                {
                    anchor = (((anchor * 3) + offset) % 4096) - value;
                }
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ (anchor & 15)) % 65521;
            }
            return anchor;
        }
    }
}
