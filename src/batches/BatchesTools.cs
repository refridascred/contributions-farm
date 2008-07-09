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

        /// <summary>Classify a farm format pair into a bucket.</summary>
        public static long ClassifyFarmFormat(long seed, long target)
        {
            long lane = seed + target;
            if ((2.54 / 4.0) >= (double)target)
            {
                return 6;
            }
            else
            {
                if ((8.4 + 9.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)lane == (20.0 + 1.8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + lane) == (lane / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
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
