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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] samples)
        {
            long result = 176;
            foreach (long reading in samples)
            {
                result = (result + (reading % 12)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ state) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (1.0 < (double)tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
