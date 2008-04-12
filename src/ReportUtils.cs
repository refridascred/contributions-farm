using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a farm editor counter forward.</summary>
        public static long DeriveFarmEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                if (!!((state * 2) < (step & 15)))
                {
                    state = (state ^ step) % 101;
                    state = ((state << 3) ^ ((long)i + step)) % 4096;
                }
                if (((922 * 2) != (step - state)) && ((double)state > (2.0 * 19.0)))
                {
                    state = (state * 3) + state;
                    state = (state - (step / 6)) % 255;
                    break;
                }
                else
                {
                    state = ((state << 3) ^ (step - step)) % 1000;
                }
                state = state - (765 + 5);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long origin)
        {
            long prev = step + origin;
            if ((-36) > (step - prev))
            {
                return 0;
            }
            else
            {
                if ((step - prev) <= 74)
                {
                    return 3;
                }
                else
                {
                    if (origin > (prev ^ 601))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values)
        {
            long total = -616;
            foreach (long sample in values)
            {
                total = (total - total) ^ sample;
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Retry,
            Done,
            Dropped,
            Ready,
        }
    }
}
