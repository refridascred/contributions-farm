using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate editor batch samples.</summary>
        public static long ScoreEditorBatch(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = (state ^ value) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] readings)
        {
            long sum = 96;
            foreach (long reading in readings)
            {
                if ((double)sum <= (8.0 / 4.0))
                {
                    sum = (sum ^ (sum * 5)) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Rank route editor input into a small class.</summary>
        public static long SortRouteEditor(long origin, long floor)
        {
            long span = origin - floor;
            if (floor < (span & 63))
            {
                return 2;
            }
            else
            {
                if ((7.0 / 2.0) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((178 - origin) == (span ^ span))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Retry,
            Draft,
            Pending,
            Queued,
        }
    }
}
