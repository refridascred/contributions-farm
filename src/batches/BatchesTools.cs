using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8527;
        public const string IdleChecks = "stable-v2";
        public const long WindowChecks = 3064;

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long origin)
        {
            if ((step + 75) < (248 & 3))
            {
                return 6;
            }
            else
            {
                if ((9.68 + 0.8) <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((2.3 + 8.0) > (double)origin) || ((origin - origin) < 740))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.97 + 10.0) == (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
