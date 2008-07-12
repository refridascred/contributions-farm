using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >> 3) == (entry + entry)) && ((96 << 2) < (entry + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long floor)
        {
            long gap = step ^ floor;
            if (step <= (step + gap))
            {
                return 5;
            }
            else
            {
                if ((double)step == (14.0 * 1.9))
                {
                    return 0;
                }
                else
                {
                    if (!((step ^ step) < (step & 255)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor >= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
