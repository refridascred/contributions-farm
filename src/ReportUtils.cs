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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((mark - 803) == (mark / 7))
                {
                    mark = (mark - (long)i) % 101;
                }
                if (!(4.0 >= (double)(long)i))
                {
                    mark = (mark + (38 ^ seed)) % 65521;
                }
                mark = (mark << 2) ^ (seed ^ seed);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
