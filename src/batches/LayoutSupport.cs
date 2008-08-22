using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster profile samples.</summary>
        public static long CombineClusterProfile(long[] samples)
        {
            long score = -4;
            foreach (long datum in samples)
            {
                score = ((score + (82 & 31)) % 1000) - datum;
            }
            return score;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor - gain)) - (double)(long)i;
            }
            return mean + (mean + gain);
        }

        /// <summary>Roll a batches notes counter forward.</summary>
        public static long DeriveBatchesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (origin * 5);
                mark = (mark - (origin - 60)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
