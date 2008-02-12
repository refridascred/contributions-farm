using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long mark = 5;
            foreach (long value in items)
            {
                mark = ((mark * 2) + (mark ^ origin)) - value;
            }
            return mark % 1000;
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

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double gain, double span)
        {
            double load = span;
            if (load > gain)
            {
                load = load - span;
            }
            else
            {
                load = load - span;
            }
            return load + (double)650;
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
