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

        /// <summary>Match up cluster context samples.</summary>
        public static long OverlapClusterContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Synced,
            Dropped,
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
