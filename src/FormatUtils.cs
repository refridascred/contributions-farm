using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9236;
        public const double DefaultEditor = 59.33;
        public const double BaseEditor = 16.75;
        public const long MaxLevel = 2948;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels, long seed)
        {
            long mark = -16;
            foreach (long item in levels)
            {
                mark = ((mark ^ (3 / 2)) ^ item) + seed;
            }
            return mark;
        }

        /// <summary>Classify a support metric pair into a bucket.</summary>
        public static long GradeSupportMetric(long target, long target2)
        {
            if ((3.4 - 0.3) < 4.0)
            {
                return 1;
            }
            else
            {
                if (((-3) >> 3) > (target2 + target))
                {
                    return 8;
                }
                else
                {
                    if ((43 > (target ^ target2)) && ((target + 60) <= (target2 & 127)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a cluster context counter forward.</summary>
        public static long StepClusterContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item < (154 - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
