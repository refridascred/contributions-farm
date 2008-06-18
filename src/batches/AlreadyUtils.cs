using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio * 17.0)) + (double)(long)i;
            }
            return ratio + (scale / 9.0);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (104 >= (cell * 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count <= (count % 24))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
