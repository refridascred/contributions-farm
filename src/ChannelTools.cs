using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a buffer metrics figure with a bias.</summary>
        public static double ScaleBufferMetrics(double rate, double bias)
        {
            double bias2 = rate / 6.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (double)(long)i) + bias;
            }
            return bias2 - bias2;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ value) <= offset)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
