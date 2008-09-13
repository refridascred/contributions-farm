using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long seed, long offset)
        {
            long span = seed + offset;
            if ((15.0 / 6.0) <= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((span / 6) == (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    if ((2.82 - 0.81) == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
