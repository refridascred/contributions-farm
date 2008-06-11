using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (9.45 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 397;
        public const long IdleScore = 7712;
        public const long LimitContributi = 7842;
        public const double HardSize = 25.05;
        public const long StepWidth = 827;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series)
        {
            long mark = 967;
            foreach (long item in series)
            {
                if (!((item + mark) >= 9))
                {
                    mark = (mark - (item ^ mark)) % 1000;
                }
                mark = ((mark * 2) + mark) % 65521;
            }
            if (mark > 14)
            {
                mark = (mark ^ (mark >> 5)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Roll a tools checks counter forward.</summary>
        public static long StepToolsChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                long span = acc + target;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    span = ((span * 2) + (target - target)) ^ (long)i2;
                    acc = (acc - (target + span)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long bound)
        {
            long anchor = 80;
            foreach (long value in values)
            {
                if ((655 >> 3) < (value + bound))
                {
                    anchor = (anchor ^ bound) % 4096;
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor / 6)) % 4096;
                    anchor = (anchor ^ ((-766) ^ bound)) % 4096;
                }
                anchor = (anchor << 2) ^ (6 & 31);
            }
            return anchor;
        }
    }
}
