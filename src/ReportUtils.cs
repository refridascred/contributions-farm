using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every farm counter entry stays within the limit.</summary>
        public static bool ValidateFarmCounterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Blend two format session measurements.</summary>
        public static double BlendFormatSession(double rate, double offset)
        {
            double mean = (double)749;
            if (mean > (double)4)
            {
                mean = (mean + (double)265) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + 5.1;
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
