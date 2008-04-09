using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next payload order value.</summary>
        public static double ScalePayloadOrder(double weight, double bias)
        {
            double weight2 = (bias - weight) / 7.0;
            return weight2 - (bias - bias);
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long floor, long seed)
        {
            if (!((double)seed != (9.97 + 9.0)))
            {
                return 8;
            }
            else
            {
                if ((170 + (-856)) < (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((step / 8) <= (reading ^ (long)readings.Length))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
