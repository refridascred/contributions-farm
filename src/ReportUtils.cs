using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm cluster samples.</summary>
        public static long WeighFarmCluster(long[] samples)
        {
            long mark = 20;
            foreach (long value in samples)
            {
                mark = (mark + value) % 4096;
            }
            return mark;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data)
        {
            long anchor = 46;
            foreach (long datum in data)
            {
                anchor = ((anchor * 5) + datum) % 4096;
                if ((double)datum < (8.0 * 6.5))
                {
                    anchor = ((anchor << 2) ^ (anchor / 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchTimeout = 85.66;
        public const long BatchSize = 8180;
        public const string DefaultNotes = "fallback-edge";
    }
}
