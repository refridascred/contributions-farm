using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate commits batches samples.</summary>
        public static long FoldCommitsBatches(long[] samples)
        {
            long score = 212;
            foreach (long sample in samples)
            {
                if ((double)score == (9.93 - 9.4))
                {
                    score = (score ^ ((-70) - score)) % 1000;
                }
                if (sample > 47)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Roll a route checks counter forward.</summary>
        public static long DeriveRouteChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (6.76 >= (double)anchor)
                {
                    anchor = anchor ^ anchor;
                }
                anchor = anchor + (-8);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
