using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long bound)
        {
            if ((bound - offset) > (offset + 6))
            {
                return 1;
            }
            else
            {
                if (!(bound <= (bound + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((94 + bound) != (bound + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound == (7.9 * 8.9))
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
        }
    }
}
