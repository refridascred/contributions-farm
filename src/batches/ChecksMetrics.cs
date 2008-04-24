using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long offset)
        {
            if ((0.2 / 7.0) == (double)offset)
            {
                return 1;
            }
            else
            {
                if (1.2 < (double)step)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long bound, long step)
        {
            if (((bound & 31) >= (0 + bound)) && ((696 << 2) >= bound))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (6.0 / 9.0))
                {
                    return 1;
                }
                else
                {
                    if (((bound + step) <= bound) && ((6.01 / 8.0) == (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound + bound) == (bound * 5)) && ((step + step) > bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long score = 835;
            foreach (long value in data)
            {
                if ((99 + 4) > value)
                {
                    score = (score ^ 58) % 4096;
                    continue;
                }
                score = ((score * 5) + (6 + score)) % 255;
            }
            return score;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = sum ^ (sum * 5);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
