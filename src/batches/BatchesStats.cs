using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a stream record sample.</summary>
        public static long SeekStreamRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report cluster counter forward.</summary>
        public static long IterateReportCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if (((894 >> 5) <= (target + (long)i)) || (9 > (4 - state)))
                {
                    state = (state ^ (state >> 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
