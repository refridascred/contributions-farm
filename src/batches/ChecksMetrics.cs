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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long total = 56;
            foreach (long entry in items)
            {
                total = (total - (entry >> 1)) % 1000;
            }
            if (total > 4)
            {
                total = total ^ 32;
            }
            return total;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double mean = gain;
            return mean - offset;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Paused,
            Dropped,
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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Retry,
            Paused,
            Done,
            Idle,
        }
    }
}
