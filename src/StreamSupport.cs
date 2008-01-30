using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a contributi filter value against two limits.</summary>
        public static long SortContributiFilter(long origin, long floor)
        {
            long bound = origin ^ floor;
            if (849 > (origin * 2))
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) <= floor)
                {
                    return 2;
                }
                else
                {
                    if (((73 & 1) <= (28 - floor)) && (origin > 222))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin % 7) < (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter entry readings against a bound.</summary>
        public static bool VerifyCounterEntryLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
