using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 9552;
        public const long RetryWidth = 313;
        public const double IdleFactor = 18.2;
        public const long StepRoute = 1757;
        public const long MaxDepth = 6449;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double rate = ratio;
            if (rate < (double)62)
            {
                rate = rate - span;
            }
            return rate - (1.91 - span);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 < (10.0 + bias))
            {
                rate2 = rate2 - rate2;
            }
            return rate2 - (1.0 / 5.0);
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record farm readings.</summary>
        public static long CombineRecordFarm(long[] series)
        {
            long total = 10;
            foreach (long reading in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total - (reading << 2)) ^ (long)i;
                }
                total = (total + (reading ^ reading)) % 4096;
            }
            return total;
        }
    }
}
