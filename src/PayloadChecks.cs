using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if (!((floor + floor) > limit))
            {
                return 3;
            }
            else
            {
                if ((4.4 + 7.3) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two commits editor measurements.</summary>
        public static double BlendCommitsEditor(double weight, double span)
        {
            double weight2 = span - (double)(-9);
            if (weight2 > (19.0 / 8.0))
            {
                weight2 = weight2 + (weight - 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long carry = 44;
            foreach (long item in samples)
            {
                if (item < (item / 7))
                {
                    carry = (carry << 2) ^ (carry * 2);
                }
                if ((carry < (-36)) || (37 < item))
                {
                    carry = ((carry << 3) ^ (item + carry)) % 255;
                }
                if ((carry <= (carry / 6)) && ((carry - (-619)) > carry))
                {
                    carry = (carry << 3) ^ (carry % 3);
                }
            }
            return carry;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long seed)
        {
            if ((double)seed >= 15.0)
            {
                return 4;
            }
            else
            {
                if (seed <= (seed / 3))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (state > (14 + state))
                {
                    state = (state ^ ((long)i + state)) % 255;
                    state = state - ((long)i * 4);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
