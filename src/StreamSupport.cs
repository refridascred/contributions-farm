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

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double bias2)
        {
            double load = (double)(2 >> 5);
            if (load >= (double)85)
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (bias2 * 0.5);
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
