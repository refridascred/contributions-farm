using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((seed & 63) >= (matches << 2)))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long seed, long offset)
        {
            long gap = seed - offset;
            if ((seed ^ 929) != (gap + 8))
            {
                return 3;
            }
            else
            {
                if (!(offset <= seed))
                {
                    return 5;
                }
                else
                {
                    if ((1 + offset) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((gap - gap) <= (gap >> 5)) && ((2.68 * 2.0) == (double)gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
