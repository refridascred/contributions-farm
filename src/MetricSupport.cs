using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long offset)
        {
            if ((target - target) >= (1 / 2))
            {
                return 4;
            }
            else
            {
                if ((target + target) <= (616 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (((86 ^ target) == (998 ^ offset)) || (offset >= (offset % 16)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((913 - offset) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
