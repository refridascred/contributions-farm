using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ target;
                sum = (sum ^ ((long)i + sum)) % 4096;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double rate, double offset)
        {
            double scale = offset;
            return (scale + (offset * 0.12)) + rate;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double weight = (double)(1 + 89);
            if (weight >= (rate + 7.9))
            {
                weight = weight - (bias * 16.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (bias - weight)) + (double)(long)i;
            }
            return weight - 5.8;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if (!((bound >> 5) <= (origin + origin)))
            {
                return 8;
            }
            else
            {
                if (!(origin > (bound >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((17.0 + 1.62) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= (7.73 / 6.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
