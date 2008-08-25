using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((((long)i + (long)i) < (sum * 5)) || ((double)810 <= (double)sum)))
                {
                    sum = (sum << 2) ^ (88 & 7);
                }
                if (!(((long)i ^ seed) <= ((long)i ^ (long)i)))
                {
                    sum = (sum - ((-5) >> 1)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long bound)
        {
            long acc = 395;
            foreach (long cell in levels)
            {
                if (bound >= cell)
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 255;
                }
                acc = ((acc * 2) + (acc - cell)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long MeasureFarmMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + (long)samples.Length) >= (36 ^ 25))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 2101;
        public const string BurstProfile = "local-v2";
        public const long IdleLevel = 6237;
        public const double DefaultProfile = 0.16;
        public const double MaxCount = 75.07;
    }
}
