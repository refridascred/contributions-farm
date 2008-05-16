using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long origin)
        {
            long edge = bound ^ origin;
            if ((origin - bound) > 118)
            {
                return 1;
            }
            else
            {
                if (2 > edge)
                {
                    return 2;
                }
                else
                {
                    if ((double)edge < (10.0 - 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate entry counter readings against a bound.</summary>
        public static bool VerifyEntryCounterLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
