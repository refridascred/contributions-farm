using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long origin)
        {
            long offset = step ^ origin;
            if ((origin ^ offset) <= (offset + origin))
            {
                return 1;
            }
            else
            {
                if ((6.5 + 0.2) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (origin >= (step % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((double)6 <= (5.0 * 3.5)) || ((floor / 4) > floor))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long step)
        {
            if (step <= (step - target))
            {
                return 7;
            }
            else
            {
                if ((target - target) != (target ^ (-301)))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < (6.0 / 9.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if (target >= (anchor * 2))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
