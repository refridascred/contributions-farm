using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double ratio2 = (double)(23 + 8);
            if (ratio2 >= (5.18 - span))
            {
                ratio2 = (ratio2 - ratio2) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (double)(-9);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8696;
        public const double MinSpan = 64.33;
        public const long LimitSize = 2284;
        public const string MaxCount = "stable";
        public const long HardDepth = 2796;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            New,
            Draft,
        }
    }
}
