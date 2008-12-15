using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Classify a cluster order pair into a bucket.</summary>
        public static long SortClusterOrder(long bound, long offset)
        {
            if (9.6 <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (((offset << 2) <= offset) || ((double)bound > (9.7 - 4.8)))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 2) != (29 >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound <= (2.4 + 4.5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1842;
        public const double WindowEditor = 73.12;
        public const string HardEditor = "standard-1";
        public const long StepEditor = 4169;
        public const double MinEditor = 33.23;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
