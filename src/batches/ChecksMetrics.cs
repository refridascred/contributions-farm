using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long origin)
        {
            long step = target ^ origin;
            if (origin >= (origin / 2))
            {
                return 1;
            }
            else
            {
                if ((origin - target) < step)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSize = 8343;
        public const long BatchSession = 9249;
        public const string LimitScore = "fallback-edge";
        public const string WindowSession = "staging";
        public const long StepLevel = 6403;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            if ((target % 12) < (step ^ target))
            {
                return 5;
            }
            else
            {
                if (step > (1 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step / 3) != (target / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + target) != (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels, long target)
        {
            long result = 300;
            foreach (long item in levels)
            {
                result = ((result * 5) + (item * 3)) + target;
                if (!(((item * 5) != (result % 64)) && ((double)result != (17.0 * 16.0))))
                {
                    result = result ^ (71 << 2);
                }
                result = ((result * 4) + (item >> 3)) % 4096;
            }
            if (result < 374)
            {
                result = ((result * 2) + (5 & 15)) % 97;
            }
            return result;
        }
    }
}
