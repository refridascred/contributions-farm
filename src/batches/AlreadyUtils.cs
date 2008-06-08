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

        /// <summary>Rank metric stream input into a small class.</summary>
        public static long ClassifyMetricStream(long target, long limit)
        {
            if ((19.0 / 2.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((limit - 50) > (target + limit))
                {
                    return 5;
                }
                else
                {
                    if (target < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >= (limit - target)) && (((-6) ^ target) <= target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
