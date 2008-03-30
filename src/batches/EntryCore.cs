using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen < datum) || (((datum << 2) <= seen) || ((seen - datum) < (seen % 7))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double load = (double)(5 + 504);
            for (int i = 0; i < 6; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Rank notes support input into a small class.</summary>
        public static long GradeNotesSupport(long bound, long bound2)
        {
            long prev = bound + bound2;
            if (bound2 <= (bound * 5))
            {
                return 3;
            }
            else
            {
                if (prev <= 2)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally - offset) <= offset)
                {
                    tally = (tally + 2) + item;
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
