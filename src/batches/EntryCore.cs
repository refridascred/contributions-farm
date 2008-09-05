using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item >> 5) > (item & 127)) || (bound > (86 + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long origin, long target)
        {
            if ((target / 7) < target)
            {
                return 1;
            }
            else
            {
                if (!((double)target == (5.7 + 2.5)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin & 31) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - origin) < (77 + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Failed,
            Pending,
        }
    }
}
