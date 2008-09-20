using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a tools stream value against two limits.</summary>
        public static long ClassifyToolsStream(long bound, long seed)
        {
            if (!((5.18 + 2.0) > (double)seed))
            {
                return 1;
            }
            else
            {
                if (seed >= (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed >= (5.0 + 6.36)) || (69 <= (bound % 60)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + 23) > (bound ^ bound))
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

        /// <summary>Accumulate tools payload samples.</summary>
        public static long TallyToolsPayload(long[] levels)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                if (((double)entry < (4.0 + 7.03)) || (entry < (mark >> 5)))
                {
                    mark = ((mark << 2) ^ (mark * 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Done,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
