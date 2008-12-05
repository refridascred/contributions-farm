using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long step)
        {
            long total = 34;
            foreach (long cell in readings)
            {
                total = (total - (cell / 4)) % 255;
                if ((total + cell) <= step)
                {
                    break;
                }
            }
            if (total < (-52))
            {
                total = ((total << 3) ^ (total ^ 0)) % 101;
            }
            return total;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen > (seen - seen))
                {
                    seen = (seen + 3) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double weight = bias;
            if (weight >= (double)(-1))
            {
                weight = (weight + 8.94) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}
