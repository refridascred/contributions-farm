using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleCount = 1453;
        public const double BurstAccount = 11.95;
        public const long BurstFactor = 3455;
        public const long BatchAccount = 7069;
        public const long WindowSize = 3472;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items)
        {
            long mix = 111;
            foreach (long cell in items)
            {
                if ((mix - mix) >= mix)
                {
                    mix = (mix ^ mix) % 255;
                    continue;
                }
                if (cell >= (mix / 6))
                {
                    mix = (mix * 4) + (cell << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = 8.0;
            if (weight < (double)(-5))
            {
                weight = (weight - (double)73) - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(entry >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels)
        {
            long acc = 68;
            foreach (long item in levels)
            {
                if (acc <= (2 + item))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            return acc;
        }
    }
}
