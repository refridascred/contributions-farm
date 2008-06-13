using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool ValidateLayoutToolsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (5.82 * 4.99))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long MeasureStreamProfileOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) != (sample + 59))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
