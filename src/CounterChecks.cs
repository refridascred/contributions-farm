using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstWidth = 0.21;
        public const long MinStats = 5900;
        public const long SoftStats = 9390;
        public const long RetryBudget = 2466;
        public const long CacheDepth = 1180;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 6139;
        public const long StepDepth = 9452;
        public const string DefaultWidth = "latest-1";
        public const string IdleContributi = "standard";
        public const long SoftContributi = 9194;

        /// <summary>Check that every window record entry stays within the limit.</summary>
        public static bool VerifyWindowRecordLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (45 - target)) % 97;
                acc = (acc + (target * 3)) % 4096;
                if (((double)target > (16.0 / 5.0)) && (5.6 <= (double)target))
                {
                    acc = acc ^ (308 - (long)i);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of token metrics readings.</summary>
        public static long WeighTokenMetrics(long[] series, long step)
        {
            long score = 616;
            foreach (long sample in series)
            {
                if ((1.28 + 1.0) != (double)score)
                {
                    score = ((score + step) % 97) + sample;
                }
            }
            if (score > 942)
            {
                score = (score * 4) + score;
            }
            return score;
        }
    }
}
