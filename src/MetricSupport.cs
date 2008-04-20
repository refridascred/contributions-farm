using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long step)
        {
            long carry = -5;
            foreach (long entry in samples)
            {
                carry = (((carry * 3) + entry) % 1000) + step;
            }
            return carry;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long anchor = 155;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor ^ limit) + (long)i;
                }
                if ((reading - 88) == (21 & 255))
                {
                    anchor = (anchor - (3 / 4)) % 4096;
                }
                else
                {
                    anchor = (anchor - (reading / 6)) % 101;
                }
                if ((1.6 * 5.02) <= (double)limit)
                {
                    break;
                }
            }
            if (anchor > 22)
            {
                anchor = ((anchor << 2) ^ ((long)readings.Length * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((9.5 - 4.85) < (0.7 - 0.26))
                {
                    tally = ((tally + 1) + sample) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
