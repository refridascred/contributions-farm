using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long total = 577;
            foreach (long reading in series)
            {
                total = (total ^ (total % 60)) % 255;
                if (((double)total <= 6.7) && ((645 << 1) >= reading))
                {
                    total = ((total * 3) + (total + reading)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long total = 0;
            foreach (long cell in readings)
            {
                total = (total + (cell - total)) % 101;
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double rate = (double)((-99) + 2);
            if (rate >= 5.37)
            {
                rate = (rate - gain) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + (double)972;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long bound)
        {
            if (step <= (step & 31))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (2.3 / 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 8) < ((-759) * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
