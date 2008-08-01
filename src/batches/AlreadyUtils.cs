using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long AuditNotesSupportGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((34 & 15) != (seen >> 2))
                {
                    seen = ((seen + 2) + value) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((sample >> 1) > (sample % 10)) && (matches < (offset + 17))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (floor * 5.95))
            {
                rate = rate - (17.0 - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 7.5) - (double)(long)i;
            }
            return rate + (gain * 9.31);
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Failed,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
