using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Synced,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool CheckBufferCounterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4767;
        public const long DefaultOrder = 3993;
        public const string WindowScore = "primary";
        public const double CacheSize = 70.99;

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if (((origin2 >> 1) < origin2) && ((origin % 3) > origin))
            {
                return 6;
            }
            else
            {
                if ((origin2 < (diff + 43)) || ((origin2 ^ diff) == (diff + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((double)diff <= 0.9)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((diff + diff) >= (origin2 + origin)) || ((origin2 % 24) != (diff % 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Draft,
            Locked,
        }
    }
}
