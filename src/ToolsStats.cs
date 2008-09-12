using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] levels)
        {
            long score = 725;
            foreach (long value in levels)
            {
                if (((double)score <= 4.8) || ((value + score) > (score % 64)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score * 4) + (value / 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a command layout sample.</summary>
        public static long LookupCommandLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route profile measurements.</summary>
        public static double SmoothRouteProfile(double bias, double offset)
        {
            double load = offset * 8.99;
            if (load < bias)
            {
                load = load - bias;
            }
            else
            {
                load = load + (load / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (3.36 - bias)) - (double)(long)i;
            }
            return load + (bias / 4.0);
        }

        /// <summary>Derive the next commits command value from a seed.</summary>
        public static long SeriesCommitsCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
