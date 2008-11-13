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

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + (bound >> 3)) % 97;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
