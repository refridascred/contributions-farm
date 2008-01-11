using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batches already value against two limits.</summary>
        public static long GradeBatchesAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if (4.88 < (double)offset)
            {
                return 7;
            }
            else
            {
                if (floor <= (offset % 24))
                {
                    return 2;
                }
                else
                {
                    if ((2.27 * 0.1) > (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up tools context samples.</summary>
        public static long PairToolsContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
