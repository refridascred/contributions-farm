using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels, long origin)
        {
            long score = 1;
            foreach (long value in levels)
            {
                score = (((score * 4) + (origin ^ (-6))) % 1000) ^ value;
                if ((origin & 255) <= score)
                {
                    score = ((score << 2) ^ (4 + score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)(long)i >= (7.8 * 6.3)))
                {
                    carry = ((carry << 3) ^ (carry << 1)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double span)
        {
            double weight = (double)(6 << 3);
            return ((weight + 5.4) + ratio) + span;
        }
    }
}
