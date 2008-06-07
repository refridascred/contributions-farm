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

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long anchor = 2;
            foreach (long cell in levels)
            {
                anchor = (anchor + (anchor + cell)) % 4096;
            }
            if (anchor > 522)
            {
                anchor = (anchor ^ (step * 4)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
