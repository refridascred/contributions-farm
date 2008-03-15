using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long bound)
        {
            long bound2 = floor + bound;
            if ((9.1 + 2.72) < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((0 + floor) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound / 7) == (88 % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound << 1) < (bound2 - floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a entry layout counter forward.</summary>
        public static long SeriesEntryLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (long)i;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
