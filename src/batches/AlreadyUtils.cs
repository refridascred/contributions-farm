using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "alpha-v2";
        public const long MinDepth = 6793;
        public const long HardTimeout = 4073;
        public const string MaxStream = "open-v2";

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long sum = 85;
            foreach (long entry in series)
            {
                if (origin <= (952 & 1))
                {
                    sum = ((sum - (sum / 6)) % 65521) - entry;
                }
            }
            if (sum < 71)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item & 31) > 49)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long target)
        {
            long acc = 516;
            foreach (long reading in samples)
            {
                if (((double)target == (1.8 / 6.0)) && ((219 + target) > acc))
                {
                    acc = acc + acc;
                    acc = acc + (reading << 2);
                }
                else
                {
                    acc = (acc << 3) ^ (reading / 3);
                    acc = acc + (acc % 100);
                }
                acc = ((acc << 3) ^ (acc + (long)samples.Length)) % 101;
                if ((2 - reading) < reading)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long floor)
        {
            long score = 91;
            foreach (long value in data)
            {
                score = (score ^ (value * 5)) + floor;
            }
            return score % 4096;
        }
    }
}
