using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Pending,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Look up the position of a buffer commits sample.</summary>
        public static long SeekBufferCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            New,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long step)
        {
            long delta = origin + step;
            if (((step * 5) < (origin / 7)) && ((double)origin <= (double)19))
            {
                return 5;
            }
            else
            {
                if ((delta + 2) > origin)
                {
                    return 6;
                }
                else
                {
                    if ((2.2 / 9.0) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long RollCommitsGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((mix >> 5) < ((long)i + bound))
                {
                    mix = (mix ^ bound) % 255;
                    mix = mix ^ (mix % 2);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long origin)
        {
            long span = step + origin;
            if (((double)span >= (7.85 + 0.1)) && ((span * 4) > origin))
            {
                return 8;
            }
            else
            {
                if (((double)span <= 10.0) && (span <= (step - origin)))
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
