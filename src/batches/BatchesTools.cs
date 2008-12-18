using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((acc << 3) >= cell)
                {
                    acc = acc - (cell % 64);
                }
                else
                {
                    acc = (acc - (cell + cell)) % 4096;
                }
            }
            if (acc < (-7))
            {
                acc = (acc ^ (acc / 2)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Locate a command format reading by value.</summary>
        public static long FindCommandFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowScore = 10.49;
        public const double BatchRoute = 8.77;
        public const string StepRoute = "strict";
        public const long BurstInterval = 4522;
        public const long BurstLevel = 9020;
    }
}
