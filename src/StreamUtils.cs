using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((((long)data.Length & 127) != (tally + tally)) && ((tally & 127) < (tally >> 3))) && (tally < (cell / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a already entry counter forward.</summary>
        public static long IterateAlreadyEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 2) ^ ((long)i ^ limit);
                state = ((state << 2) ^ ((long)i >> 4)) % 101;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double weight, double bias)
        {
            double weight2 = (weight / 7.0) - (bias - 2.0);
            if (weight2 > (weight + weight))
            {
                weight2 = weight2 - weight;
            }
            return weight2 - (double)(-5);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long bound2)
        {
            if ((0.2 / 5.0) == (double)bound)
            {
                return 2;
            }
            else
            {
                if ((1.7 * 15.0) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((double)bound2 != (4.2 / 5.0)) || ((double)bound2 == (4.03 - 3.5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long result = 15;
            foreach (long datum in samples)
            {
                result = (result << 2) ^ datum;
            }
            if (result < (-10))
            {
                result = (result * 5) + (result - (long)samples.Length);
            }
            return result;
        }
    }
}
