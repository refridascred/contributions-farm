using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items, long step)
        {
            long mark = 410;
            foreach (long reading in items)
            {
                mark = ((((mark * 4) + (mark & 7)) % 97) + reading) + step;
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double rate = (double)23 / 2.0;
            if (rate >= 8.0)
            {
                rate = (rate - span) - weight;
            }
            else
            {
                rate = rate + (double)7;
            }
            return rate - (double)(-78);
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values)
        {
            long total = 8;
            foreach (long datum in values)
            {
                if (((2.2 / 9.0) >= (double)total) || ((double)datum == (5.7 + 5.7)))
                {
                    total = (total << 2) ^ (long)values.Length;
                }
                if (((datum * 5) < (total + total)) && (datum <= (datum ^ datum)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate farm metric readings against a bound.</summary>
        public static bool ValidateFarmMetricBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
