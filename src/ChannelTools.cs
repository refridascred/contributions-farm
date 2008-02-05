using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinLevel = 25.35;
        public const long WindowSpan = 1611;
        public const long LimitToken = 4445;
        public const long SoftToken = 1467;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen * 5) > reading)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long step)
        {
            if ((double)limit > 4.4)
            {
                return 0;
            }
            else
            {
                if (!((limit - step) <= (step ^ 44)))
                {
                    return 3;
                }
                else
                {
                    if (!((5.12 * 2.23) != (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step >= (7.67 - 2.34)) || ((step ^ 52) <= step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
