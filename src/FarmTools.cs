using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long step, long step2)
        {
            long next = step ^ step2;
            if (next >= step)
            {
                return 0;
            }
            else
            {
                if ((4.0 / 4.0) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((next - step) < step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool GuardNotesBufferLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
