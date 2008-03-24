using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long step)
        {
            long gap = origin + step;
            if ((3.0 * 3.32) <= (double)gap)
            {
                return 1;
            }
            else
            {
                if (step > (step + origin))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                long count = offset;
                if (!((offset >= (129 & 3)) && ((count - 654) != (mix - mix))))
                {
                    mix = (mix + (count ^ 738)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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
