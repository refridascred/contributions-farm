using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long target)
        {
            if ((floor - floor) >= floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (9.02 / 8.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitInterval = 3166;
        public const long HardSchema = 9404;
        public const string LimitSize = "stable-v2";

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double gain, double floor)
        {
            double bias = floor;
            if (bias >= (bias - floor))
            {
                bias = bias - (gain * 4.7);
            }
            return bias + (floor / 5.0);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i / 2) <= ((long)i << 3))
                {
                    anchor = (anchor * 5) + step;
                }
                if (7 > (step << 3))
                {
                    anchor = ((anchor * 5) + (long)i) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score - limit) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
