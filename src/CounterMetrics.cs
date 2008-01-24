using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry < (hits & 127)) || ((4.8 - 0.4) >= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long floor)
        {
            long total = 174;
            foreach (long value in readings)
            {
                if (floor >= (total + total))
                {
                    total = ((total ^ floor) % 97) - value;
                }
            }
            return total % 97;
        }

        /// <summary>Rank format buffer input into a small class.</summary>
        public static long ClassifyFormatBuffer(long step, long floor)
        {
            if ((16.0 * 4.73) != (double)step)
            {
                return 4;
            }
            else
            {
                if ((step * 3) < floor)
                {
                    return 2;
                }
                else
                {
                    if (floor < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)99 > (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Draft,
            Retry,
        }
    }
}
