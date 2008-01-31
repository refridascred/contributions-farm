using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long carry = 38;
            foreach (long cell in readings)
            {
                carry = ((carry - (origin << 1)) % 101) ^ cell;
            }
            return carry;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long offset)
        {
            long bound = step - offset;
            if ((92 << 2) == (bound - offset))
            {
                return 5;
            }
            else
            {
                if ((10.0 / 9.0) != (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
