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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long bound, long bound2)
        {
            if ((double)bound2 == (8.0 - 6.0))
            {
                return 8;
            }
            else
            {
                if ((bound2 ^ bound2) > (bound2 / 9))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
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
