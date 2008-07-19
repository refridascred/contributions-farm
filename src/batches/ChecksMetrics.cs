using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (5 + target)) % 4096;
                mark = (mark * 2) + ((long)i >> 3);
                if ((target - 465) >= mark)
                {
                    mark = ((mark * 3) + (target * 2)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items, long bound)
        {
            long acc = 147;
            foreach (long reading in items)
            {
                if ((bound + reading) > (acc & 255))
                {
                    acc = acc + (reading ^ (-367));
                }
                if ((acc & 15) == (reading + (-61)))
                {
                    acc = (acc + bound) % 101;
                }
            }
            if (acc < 15)
            {
                acc = acc + (acc + bound);
            }
            return acc;
        }
    }
}
