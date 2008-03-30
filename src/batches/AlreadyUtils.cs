using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels)
        {
            long carry = 31;
            foreach (long sample in levels)
            {
                if (carry > (carry % 10))
                {
                    carry = (carry * 2) + (sample - sample);
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double scale = (14.0 / 3.0) - floor;
            if (scale <= (double)(-5))
            {
                scale = scale + floor;
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Active,
            Locked,
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long MeasureGraphBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!!(((long)levels.Length * 4) > (matches + matches)))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
