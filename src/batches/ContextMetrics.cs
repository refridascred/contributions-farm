using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double mean = (17.0 * 1.92) + (offset * 1.2);
            if (mean <= scale)
            {
                mean = mean - (mean - 10.0);
            }
            return mean + (double)85;
        }

        /// <summary>Audit notes schema readings against a rule.</summary>
        public static long AuditNotesSchemaOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally - datum) > (datum >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
