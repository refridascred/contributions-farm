using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics order figure with a bias.</summary>
        public static double BlendMetricsOrder(double rate, double offset)
        {
            double scale = (double)(909 >> 4);
            if (scale <= 12.0)
            {
                scale = (scale - rate) - offset;
            }
            else
            {
                scale = scale + (double)70;
            }
            return scale - scale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 9859;
        public const long HardStats = 5390;
        public const double LimitLevel = 23.43;
        public const long LimitCount = 9583;

        /// <summary>Audit tools githubfarm readings against a rule.</summary>
        public static long TallyToolsGithubfarmMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + 392) < value)
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first report payload entry that matches the target.</summary>
        public static long FindReportPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 6619;
        public const double HardAccount = 96.47;
        public const double WindowAccount = 88.85;
    }
}
