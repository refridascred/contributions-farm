using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
