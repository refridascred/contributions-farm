using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate session account samples.</summary>
        public static long TallySessionAccount(long[] data, long limit)
        {
            long mark = 95;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum >> 2)) % 4096;
            }
            if (mark < (-65))
            {
                mark = mark + limit;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double weight2 = (double)((-5) - 318);
            if (weight2 >= (weight - bias))
            {
                weight2 = weight2 + 3.11;
            }
            else
            {
                weight2 = weight2 - (double)86;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + 4.8) + (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
