using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long LocateRouteFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long limit)
        {
            if ((origin + limit) >= (limit - 65))
            {
                return 0;
            }
            else
            {
                if ((limit + 699) <= (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (8.0 + 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((881 - limit) >= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long target)
        {
            if ((0.38 + 4.1) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)seed > (7.46 - 4.6))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Retry,
            Done,
            Draft,
            Stale,
        }
    }
}
