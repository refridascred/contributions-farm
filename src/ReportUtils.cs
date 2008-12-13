using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long target)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = ((score + target) % 101) - entry;
            }
            if (score > 3)
            {
                score = (score - (score + (long)levels.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if ((26 * 3) == (long)i)
                {
                    mark = (mark << 3) ^ 5;
                    mark = (mark * 5) + (target + target);
                }
                mark = (mark << 2) ^ ((long)i >> 3);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a schema entry sample.</summary>
        public static long LookupSchemaEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
