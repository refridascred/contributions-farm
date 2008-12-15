using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster order pair into a bucket.</summary>
        public static long SortClusterOrder(long bound, long offset)
        {
            if (9.6 <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (((offset << 2) <= offset) || ((double)bound > (9.7 - 4.8)))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 2) != (29 >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= (2.4 + 4.5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
