using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double scale2 = (double)((-7) * 2);
            if (scale2 <= scale)
            {
                scale2 = (scale2 + scale) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (double)936) + (double)(long)i;
            }
            return scale2 - (double)(-6);
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) <= (-750))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long anchor = 915;
            foreach (long item in series)
            {
                if ((5.4 - 16.0) <= (double)anchor)
                {
                    anchor = ((anchor - (894 << 2)) % 255) - item;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
                if (!(anchor >= (anchor / 5)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Queued,
            Done,
        }
    }
}
