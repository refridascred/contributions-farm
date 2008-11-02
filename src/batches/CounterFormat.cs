using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue metrics samples are out of range.</summary>
        public static long CountQueueMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long seed)
        {
            long edge = origin ^ seed;
            if (!(((-6) - seed) > (origin + edge)))
            {
                return 8;
            }
            else
            {
                if ((origin % 12) <= (seed - origin))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed < (0.9 - 9.0)) && (origin < (origin + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)origin > (18.0 / 6.0)) || ((seed ^ 6) < edge))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Ready,
            Failed,
            New,
            Locked,
        }
    }
}
