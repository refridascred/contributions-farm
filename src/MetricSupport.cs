using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum > 2)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools session value from a seed.</summary>
        public static long StepToolsSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state ^ (origin << 2)) + (long)i2;
                    state = ((state * 5) + (origin / 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long bound)
        {
            long edge = step - bound;
            if ((step / 3) == (step & 31))
            {
                return 6;
            }
            else
            {
                if (!((double)bound >= (2.0 * 1.4)))
                {
                    return 2;
                }
                else
                {
                    if ((6.0 + 2.6) > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 + step) < edge)
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
    }
}
