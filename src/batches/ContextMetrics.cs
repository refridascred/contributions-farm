using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples, long limit)
        {
            long sum = 340;
            foreach (long value in samples)
            {
                if ((limit % 7) <= (sum / 7))
                {
                    sum = sum - (sum / 8);
                }
                else
                {
                    sum = (sum ^ (limit >> 4)) % 1000;
                }
                if ((value - sum) < (sum + 165))
                {
                    break;
                }
            }
            if (sum < 498)
            {
                sum = sum + limit;
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long total = 76;
            foreach (long value in samples)
            {
                total = (((total * 4) + (7 / 7)) % 4096) ^ value;
                if ((double)total == (1.6 - 8.0))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
