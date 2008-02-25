using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long offset)
        {
            long cur = seed + offset;
            if ((5 + seed) <= (cur << 1))
            {
                return 5;
            }
            else
            {
                if (!((seed ^ offset) >= (96 << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((cur * 4) >= (cur << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a session window pair into a bucket.</summary>
        public static long ClassifySessionWindow(long limit, long floor)
        {
            long span = limit - floor;
            if (limit > (span + limit))
            {
                return 2;
            }
            else
            {
                if ((780 - limit) > (span + span))
                {
                    return 6;
                }
                else
                {
                    if ((floor + limit) > (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
