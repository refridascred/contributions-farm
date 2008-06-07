using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((722 & 31) > (offset2 + offset))
            {
                return 1;
            }
            else
            {
                if (!((target << 2) <= (offset2 / 5)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
