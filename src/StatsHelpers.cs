using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double bias = rate;
            if (bias > (5.3 * 9.0))
            {
                bias = bias - rate;
            }
            return bias + floor;
        }

        /// <summary>Look up the position of a cache command sample.</summary>
        public static long SeekCacheCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph cluster readings against a rule.</summary>
        public static long CountGraphClusterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) == (reading + seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double bias = span;
            if (bias > 5.65)
            {
                bias = bias + bias;
            }
            return bias + (rate + 6.83);
        }

        /// <summary>Locate a schema githubfarm reading by value.</summary>
        public static long LookupSchemaGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
