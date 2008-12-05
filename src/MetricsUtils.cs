using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((double)cur <= (16.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((cur + cur) != (floor + 28))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (6.9 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many queue report samples are out of range.</summary>
        public static long TallyQueueReportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((tally >> 2) <= (tally / 2)) || ((5 - datum) <= (tally >> 5))) || (((tally + tally) > (tally * 3)) && (datum < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long total = 9;
            foreach (long sample in data)
            {
                if (sample <= (912 / 2))
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = (total + (sample - (long)data.Length)) % 65521;
                }
            }
            if (total > (-762))
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double floor)
        {
            double gain = weight;
            if (gain <= gain)
            {
                gain = gain - (double)634;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + weight) - (double)(long)i;
            }
            return gain + floor;
        }
    }
}
