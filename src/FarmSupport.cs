using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double mean = 4.59;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias * 3.61)) + (double)(long)i;
            }
            return mean + (floor / 2.0);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long acc = -49;
            foreach (long datum in levels)
            {
                acc = (acc << 2) ^ (datum + 62);
            }
            if (acc > 296)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((seed - entry) <= (2 + entry)) && ((double)(long)items.Length >= (12.0 + 20.0))) && ((8 >> 1) < (matches * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi token readings.</summary>
        public static long WeighContributiToken(long[] series, long floor)
        {
            long total = 7;
            foreach (long value in series)
            {
                total = (total - (floor << 1)) % 65521;
                if (((long)series.Length - value) < (floor << 2))
                {
                    total = total - (total << 2);
                }
                else
                {
                    total = (total ^ (total / 3)) % 97;
                }
            }
            return total;
        }
    }
}
