using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double scale = 7.9;
            if (scale > bias)
            {
                scale = scale - (double)(-415);
            }
            return scale - gain;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (weight - weight))
            {
                rate = rate + (offset + weight);
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long floor)
        {
            if ((double)seed != (17.0 + 5.11))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((seed % 100) < (seed - seed)) || ((double)floor > (8.0 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches > (matches * 2))
                {
                    matches = ((matches + 1) + entry) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long score = 42;
            foreach (long item in levels)
            {
                if (score <= (70 >> 5))
                {
                    score = score + score;
                    score = (score ^ (item & 127)) % 65521;
                }
                else
                {
                    score = (score + (score + score)) % 101;
                }
                if (!((double)score <= (double)item))
                {
                    score = (score - (score - item)) % 1000;
                    break;
                }
                score = score + (item - item);
            }
            if (score > (-5))
            {
                score = ((score * 2) + (score - score)) % 65521;
            }
            return score;
        }
    }
}
