using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a window buffer counter forward.</summary>
        public static long DeriveWindowBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)mix <= (19.0 - 2.6)))
                {
                    mix = (mix + (floor + floor)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long acc = 805;
            foreach (long sample in readings)
            {
                acc = ((((acc << 2) ^ acc) % 255) - sample) - target;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)tally < (double)sample) && (((double)bound >= (double)tally) && (8.0 >= (double)sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long TallyCounterReportHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)floor)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi already entries that pass the check.</summary>
        public static long TallyContributiAlreadyMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((tally & 3) < (step << 1)))
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
