using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank graph commits input into a small class.</summary>
        public static long GradeGraphCommits(long limit, long origin)
        {
            if ((9 / 6) >= (206 ^ limit))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 0.3) && (limit > (origin % 97)))
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 3.25;
        public const string WindowOrder = "standard-v2";
        public const double RetryOrder = 26.18;
        public const double StepScore = 48.72;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((gap - gap) >= offset2)
            {
                return 4;
            }
            else
            {
                if ((double)offset2 >= (8.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (6.9 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 >> 3) < (806 + offset2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
