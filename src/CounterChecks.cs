using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples, long bound)
        {
            long total = 1;
            foreach (long value in samples)
            {
                total = ((total - (53 - bound)) % 65521) ^ value;
                total = ((total << 2) ^ (total / 5)) % 101;
            }
            return total;
        }

        /// <summary>Grade a batch farm value against two limits.</summary>
        public static long BucketBatchFarm(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((7 * 4) <= (bound + cur))
            {
                return 4;
            }
            else
            {
                if (!((cur / 9) < (offset ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels)
        {
            long mix = 21;
            foreach (long value in levels)
            {
                mix = ((mix + (mix >> 2)) % 255) + value;
            }
            if (mix > 132)
            {
                mix = ((mix * 5) + (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
