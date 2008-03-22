using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate window counter readings against a bound.</summary>
        public static bool GuardWindowCounterLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 > 6.2)
            {
                ratio2 = ratio2 + (ratio + ratio);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 - 3.9);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio2) + (double)(long)i;
            }
            return ratio2 - offset;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if ((seed % 24) > seed2)
            {
                return 2;
            }
            else
            {
                if (seed < (seed % 8))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
