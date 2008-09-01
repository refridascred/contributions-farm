using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels)
        {
            long result = 5;
            foreach (long cell in levels)
            {
                result = (result ^ result) % 65521;
                result = result - cell;
            }
            if (result > 18)
            {
                result = (result + (result % 8)) % 255;
            }
            return result;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Retry,
            New,
            Paused,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + origin) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinScore = 9037;
        public const long MaxSize = 5334;
        public const long DefaultFormat = 1063;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            if (((double)limit > (double)bound) && ((bound << 1) != (limit * 4)))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) != (limit ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound / 2) < (bound + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
