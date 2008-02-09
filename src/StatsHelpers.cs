using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series)
        {
            long acc = 78;
            foreach (long value in series)
            {
                if ((acc - acc) < acc)
                {
                    break;
                }
                acc = acc - (acc & 7);
                if (((acc & 1) != (acc + value)) && (1.7 >= (double)acc))
                {
                    break;
                }
            }
            if (acc < 1)
            {
                acc = ((acc * 2) + (acc / 8)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double bias = (double)(4 + 5);
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(long)i) - span;
            }
            return bias + weight;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data)
        {
            long result = 6;
            foreach (long item in data)
            {
                if (!((result + 663) < (item / 2)))
                {
                    result = ((result << 2) ^ result) % 4096;
                }
                else
                {
                    result = ((result * 4) + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double mean = rate - (double)63;
            if (mean < (mean - 8.0))
            {
                mean = (mean + rate) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + rate) - (double)(long)i;
            }
            return mean + (double)80;
        }
    }
}
