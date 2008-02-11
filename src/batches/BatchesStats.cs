using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 >= ((long)readings.Length % 64)) && (9.8 >= (double)tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items)
        {
            long total = 18;
            foreach (long reading in items)
            {
                if (23 > (total << 1))
                {
                    total = (((total << 2) ^ total) % 255) - reading;
                }
                else
                {
                    total = ((total << 3) ^ (total - 657)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
