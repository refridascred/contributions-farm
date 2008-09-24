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

        /// <summary>Count the counter batch entries that pass the check.</summary>
        public static long AuditCounterBatchGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((8.2 / 9.0) >= (double)limit)
                {
                    matches = (matches + 2) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
