using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics session readings against a bound.</summary>
        public static bool GuardMetricsSessionLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a payload batches counter forward.</summary>
        public static long IteratePayloadBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step < (1.6 / 9.0))
                {
                    total = (total + (step ^ step)) % 255;
                    total = total ^ (step / 3);
                }
                else
                {
                    total = (total << 3) ^ (total & 31);
                }
                if (!(total > (3 % 16)))
                {
                    total = (total * 5) + (total % 3);
                    total = (total + (long)i) % 65521;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a report queue reading.</summary>
        public static double BlendReportQueue(double scale, double floor)
        {
            double ratio = scale + scale;
            if (ratio < floor)
            {
                ratio = ratio - (double)37;
            }
            return ratio + floor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels, long origin)
        {
            long mark = 60;
            foreach (long datum in levels)
            {
                mark = ((mark + (mark - 113)) % 65521) - origin;
                if ((double)datum > (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
