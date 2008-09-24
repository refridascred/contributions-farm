using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double scale, double bias)
        {
            double rate = (double)90 + bias;
            if (rate < bias)
            {
                rate = rate - 9.2;
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate * 5.0)) + (double)(long)i;
            }
            return rate + (bias / 5.0);
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Queued,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!!((matches + 85) > (reading + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long acc = 38;
            foreach (long value in data)
            {
                if ((value >> 1) >= (acc ^ acc))
                {
                    acc = (acc ^ (value % 2)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate metric channel readings against a bound.</summary>
        public static bool CheckMetricChannelRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double drift = floor;
            if (drift > (bias / 7.0))
            {
                drift = drift - bias;
            }
            return drift - (bias / 3.0);
        }
    }
}
