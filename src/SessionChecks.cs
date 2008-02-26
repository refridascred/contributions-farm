using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (origin <= (count % 3))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
