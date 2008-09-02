using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) >= (904 - count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Count the account record entries that pass the check.</summary>
        public static long MeasureAccountRecordHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= (4.0 - 17.0)) && ((double)cell <= 1.5))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double bias)
        {
            double gain = 2.81;
            if (gain >= (double)289)
            {
                gain = ((gain - 4.2) + rate) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - 4.1) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
