using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (state ^ seed);
                state = (state + (seed ^ (long)i)) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many payload command samples are out of range.</summary>
        public static long MeasurePayloadCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(7 > (entry + entry)) || (tally >= (tally - entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double mean = rate - bias;
            if (mean <= (rate * 8.4))
            {
                mean = mean - (1.0 + 4.6);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)653) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
