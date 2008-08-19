using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchInterval = 18.65;
        public const long DefaultRatio = 2165;
        public const long BaseCache = 9226;
        public const long StepCount = 5687;
        public const long StepLevel = 1399;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate order counter readings against a bound.</summary>
        public static bool VerifyOrderCounterLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((sample + matches) == (30 & 127)) && ((double)sample > (double)771)) && (sample > ((-36) % 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
