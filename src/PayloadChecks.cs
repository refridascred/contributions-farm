using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series, long bound)
        {
            long total = 25;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ bound) % 65521) - reading;
            }
            if (total < 34)
            {
                total = (total ^ (total + bound)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Project the next graph tools value.</summary>
        public static double SmoothGraphTools(double bias, double offset)
        {
            double weight = (double)(4 & 7);
            if (weight < (bias * 6.0))
            {
                weight = (weight - (double)4) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - 4.8;
        }

        /// <summary>Combine report metrics values into a single score.</summary>
        public static long TotalReportMetrics(long[] readings, long bound)
        {
            long mix = 75;
            foreach (long value in readings)
            {
                if ((1.0 / 4.0) >= (double)value)
                {
                    mix = ((mix * 3) + ((long)readings.Length + bound)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long DigestSupportContributi(long[] levels)
        {
            long total = 360;
            foreach (long item in levels)
            {
                if (!!((total - total) >= (7 - item)))
                {
                    total = ((total * 3) + (item + total)) % 101;
                }
                if ((double)(long)levels.Length > (5.75 / 9.0))
                {
                    total = ((total << 2) ^ (item - total)) % 97;
                }
            }
            if (total < 428)
            {
                total = (total - (total % 12)) % 101;
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            New,
            Failed,
            Stale,
        }
    }
}
