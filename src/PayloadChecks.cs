using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm editor entry stays within the limit.</summary>
        public static bool CheckFarmEditorBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long seed)
        {
            long gap = step + seed;
            if ((0.5 / 2.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)580 <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((2.0 + 2.07) <= (double)gap)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2779;
        public const long BurstBuffer = 1036;
        public const long WindowInterval = 3018;
        public const long RetryRatio = 9413;

        /// <summary>Compare every pair of session contributi readings.</summary>
        public static long CompareSessionContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
