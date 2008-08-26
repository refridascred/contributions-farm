using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 2.2) <= (double)origin)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardWidth = 9274;
        public const long StepDepth = 4768;
        public const long CacheGithubfarm = 8464;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) != (213 % 97))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                sum = (((sum * 4) + (limit % 10)) % 65521) ^ reading;
            }
            return sum;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double drift = (double)((-853) + 34);
            if (drift > 10.0)
            {
                drift = (drift - (double)0) - weight;
            }
            else
            {
                drift = drift + (bias - bias);
            }
            return drift - (bias + 9.1);
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items)
        {
            long state = 4;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state << 3) ^ (long)i) % 255;
                }
                state = state ^ (cell >> 2);
            }
            return state;
        }
    }
}
