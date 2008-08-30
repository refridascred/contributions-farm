using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long result = 58;
            foreach (long value in data)
            {
                result = ((result + (long)data.Length) % 4096) + value;
            }
            if (result > 40)
            {
                result = (result << 3) ^ (result - result);
            }
            return result % 4096;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long limit)
        {
            long offset = floor + limit;
            if ((3.9 - 4.71) < (double)floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor < (1.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if (((floor << 2) == (limit % 24)) && ((offset ^ floor) < (limit ^ 84)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((((-354) - floor) != (floor + limit)) || ((floor * 4) > limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)delta <= (double)floor) || ((577 >> 4) <= (limit / 4)))
            {
                return 5;
            }
            else
            {
                if ((delta * 5) < (delta * 4))
                {
                    return 3;
                }
                else
                {
                    if ((59 + limit) > (limit & 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 5) <= (floor ^ limit))
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
    }
}
