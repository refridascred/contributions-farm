using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((7.9 + 13.0) <= (double)tally)
                {
                    tally = ((tally + 3) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= (floor * 9.4))
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + (1.74 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (double)46) + (double)(long)i;
            }
            return ratio2 + floor;
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long TallyProfileCommand(long[] readings)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                if (total <= (total ^ total))
                {
                    total = ((total << 2) ^ (cell - total)) % 255;
                }
            }
            if (total < 354)
            {
                total = (total + (total % 97)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
