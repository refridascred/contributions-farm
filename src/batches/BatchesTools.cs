using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long floor, long step)
        {
            if (!(251 > (203 + step)))
            {
                return 8;
            }
            else
            {
                if (floor >= ((-8) >> 5))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank schema channel input into a small class.</summary>
        public static long GradeSchemaChannel(long seed, long offset)
        {
            if ((seed * 5) < (seed + offset))
            {
                return 4;
            }
            else
            {
                if (!((0.6 - 7.7) < (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
