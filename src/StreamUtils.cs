using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first order githubfarm entry that matches the target.</summary>
        public static long SeekOrderGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double load = span;
            if (load <= (7.0 + load))
            {
                load = load - (double)1;
            }
            return load + scale;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchTimeout = 2144;
        public const long IdleStats = 9262;
        public const long DefaultInterval = 6360;
        public const string WindowStats = "fallback";

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (double)985)
            {
                drift = (drift + (double)1) - floor;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - drift;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed - (-3)) != (sample ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
