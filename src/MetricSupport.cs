using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((limit >= entry) && (((long)values.Length % 10) <= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long target)
        {
            long state = 586;
            foreach (long reading in readings)
            {
                if (!((double)state >= (1.2 - 1.4)))
                {
                    state = (((state * 2) + (target + 271)) % 1000) + reading;
                }
                else
                {
                    state = ((state * 2) + (state + state)) % 101;
                }
            }
            return state % 1000;
        }
    }
}
