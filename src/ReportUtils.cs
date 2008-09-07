using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long limit)
        {
            long state = 370;
            foreach (long item in series)
            {
                state = ((state << 2) ^ item) - limit;
                if (!((state / 9) >= (state * 3)))
                {
                    state = ((state << 2) ^ (899 >> 5)) % 97;
                }
                state = state + (state * 2);
            }
            return state;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches - 4) <= entry) && ((entry ^ 452) > (entry * 2)))
                {
                    matches = (matches + 1) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
