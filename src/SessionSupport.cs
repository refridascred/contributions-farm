using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((entry & 63) <= entry) || ((entry >> 5) < entry)) || !((tally % 8) > entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double mean = (double)((-545) + (-40));
            if (mean > bias2)
            {
                mean = mean - (bias2 + bias2);
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + (9.4 - bias);
        }

        /// <summary>Accumulate command tools samples.</summary>
        public static long TallyCommandTools(long[] readings, long limit)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                if (limit <= (value >> 2))
                {
                    acc = acc + 21;
                }
            }
            if (acc > 103)
            {
                acc = (acc + (acc - 296)) % 101;
            }
            return acc % 97;
        }
    }
}
