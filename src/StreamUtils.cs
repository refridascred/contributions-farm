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

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                mix = ((mix * 3) + (cell + cell)) - origin;
            }
            return mix;
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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long bound)
        {
            if (bound < (2 % 8))
            {
                return 3;
            }
            else
            {
                if ((bound << 1) >= bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
