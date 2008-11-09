using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double drift = (double)538 / 7.0;
            if (drift > (ratio + offset))
            {
                drift = drift - offset;
            }
            return drift + (offset - offset);
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Queued,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((double)sample != (2.29 + 4.95)) && (count < (count << 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Paused,
        }
    }
}
