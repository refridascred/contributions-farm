using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch profile entries.</summary>
        public static long FoldBatchProfile(long[] values, long step)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = ((total * 5) + (step ^ total)) % 4096;
                if ((total > ((long)values.Length * 4)) && ((datum - 846) == (total << 1)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Dropped,
            Idle,
            Locked,
            Queued,
        }
    }
}
