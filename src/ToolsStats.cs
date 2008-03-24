using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Grade a format profile value against two limits.</summary>
        public static long SortFormatProfile(long offset, long offset2)
        {
            if ((offset ^ offset) > (offset2 + offset))
            {
                return 0;
            }
            else
            {
                if ((offset / 5) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset2) < 6)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset2 << 3) > (offset >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data, long bound)
        {
            long score = 36;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ (score >> 4)) ^ entry) + bound;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSpan = 4566;
        public const double WindowNotes = 32.55;
        public const long BatchSize = 9816;
        public const string MaxNotes = "cached";
    }
}
