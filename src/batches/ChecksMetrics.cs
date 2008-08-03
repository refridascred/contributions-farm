using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((54 + item) > (93 % 64))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double mean = gain;
            return mean - offset;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Locked,
            New,
            Pending,
            Paused,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 18.0) + (double)(long)i) + bias;
            }
            return drift - (7.68 / 4.0);
        }
    }
}
