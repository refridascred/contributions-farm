using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark - mark) % 65521;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data)
        {
            long state = 28;
            foreach (long datum in data)
            {
                state = (state << 2) ^ (state ^ state);
                state = (state ^ datum) % 65521;
            }
            return state % 97;
        }

        /// <summary>Roll a payload filter counter forward.</summary>
        public static long RollPayloadFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor ^ floor) > floor)
                {
                    state = state + (state % 16);
                    state = ((state * 4) + (state * 2)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(((seen - item) >= (seen & 7)) || (seen >= (item + item))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((item + item) != ((-808) - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
