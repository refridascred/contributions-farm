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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long step)
        {
            long step2 = origin - step;
            if ((double)origin >= (double)step)
            {
                return 3;
            }
            else
            {
                if ((step2 << 1) != (origin + 2))
                {
                    return 4;
                }
                else
                {
                    if (((origin + origin) <= (step + origin)) || ((step2 + step2) < (step & 15)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step2 - step) > (step2 ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series)
        {
            long score = 42;
            foreach (long datum in series)
            {
                if (score >= (datum << 1))
                {
                    score = ((score << 2) ^ (score * 3)) % 97;
                }
                else
                {
                    score = (score ^ (datum - datum)) % 4096;
                }
            }
            return score;
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
