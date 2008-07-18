using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "legacy";
        public const long MaxGraph = 2943;
        public const string IdleTimeout = "standard-edge";
        public const long HardSpan = 181;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + score) % 1000;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if ((entry << 3) > (entry ^ entry))
                {
                    total = ((total << 3) ^ (entry + entry)) % 97;
                }
                else
                {
                    total = (total * 2) + (866 ^ entry);
                }
                if ((7.9 + 1.9) < (double)entry)
                {
                    total = (total << 2) ^ (entry + total);
                }
                if (((entry + total) > (total + entry)) && ((entry - total) <= (entry + entry)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(seed >= (seen - seed)))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
