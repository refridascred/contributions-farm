using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)target != (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (549 > (offset + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics route pair into a bucket.</summary>
        public static long ClassifyMetricsRoute(long floor, long step)
        {
            if ((0 - floor) >= (floor / 4))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (0.6 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 2) <= (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > (4 - floor)) && ((7.46 / 4.0) == (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)bound >= (double)state))
                {
                    state = ((state * 3) + ((long)i / 5)) % 97;
                    state = state + (state + bound);
                }
                state = state - (143 + 0);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(value <= (5 * 2)))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
