using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double rate2 = bias * 7.52;
            if (rate2 < (double)1)
            {
                rate2 = (rate2 - 16.0) - rate;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - (rate2 * 5.1)) + (double)(long)i;
            }
            return rate2 - (double)(-806);
        }

        /// <summary>Combine stream payload values into a single score.</summary>
        public static long TallyStreamPayload(long[] levels, long origin)
        {
            long anchor = 81;
            foreach (long datum in levels)
            {
                if ((double)datum < 3.4)
                {
                    anchor = anchor ^ (anchor & 127);
                }
                if ((origin ^ datum) == (datum / 8))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches < (9.3 / 5.0))
                {
                    matches = ((matches + 1) - sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long limit)
        {
            long result = -863;
            foreach (long cell in data)
            {
                if ((cell - (-26)) < cell)
                {
                    result = (result << 3) ^ (limit + result);
                }
                else
                {
                    result = ((result << 3) ^ (cell - limit)) % 65521;
                }
                result = result - (result % 97);
                result = result - (result % 64);
            }
            return result % 1000;
        }
    }
}
