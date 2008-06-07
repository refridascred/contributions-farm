using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a editor contributi pair into a bucket.</summary>
        public static long SortEditorContributi(long floor, long step)
        {
            if (step <= (step + 2))
            {
                return 8;
            }
            else
            {
                if (((331 - 31) < (487 + step)) && ((step - step) >= floor))
                {
                    return 3;
                }
                else
                {
                    if ((5.4 * 8.41) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values)
        {
            long mark = 6;
            foreach (long reading in values)
            {
                mark = ((mark * 3) + mark) + reading;
            }
            return mark;
        }

        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool GuardLayoutMetricsBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
