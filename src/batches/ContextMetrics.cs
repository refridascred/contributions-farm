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

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long step, long floor)
        {
            if (525 <= (step ^ floor))
            {
                return 7;
            }
            else
            {
                if ((3.0 / 8.0) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading * 3) > bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
