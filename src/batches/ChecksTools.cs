using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema layout measurements.</summary>
        public static double ScaleSchemaLayout(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (bias * 5.0))
            {
                rate = rate + (double)9;
            }
            return rate - ratio;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value > (step << 2)) || ((2.2 / 7.0) >= (double)step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
