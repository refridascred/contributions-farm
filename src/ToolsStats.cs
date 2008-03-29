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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double weight = span + (double)7;
            if (weight > (weight * 3.1))
            {
                weight = (weight + (double)81) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (span / 8.0);
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
