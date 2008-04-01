using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double weight2 = (double)(23 / 5);
            if (weight2 <= (weight * 18.0))
            {
                weight2 = weight2 + (weight2 + span);
            }
            return weight2 + weight;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first already checks entry that matches the target.</summary>
        public static long LookupAlreadyChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 7768;
        public const long IdleCount = 5092;
        public const long WindowSpan = 5295;
        public const string SoftSupport = "standard-v2";
        public const long IdleScore = 4404;
    }
}
