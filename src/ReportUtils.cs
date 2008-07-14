using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm command entries.</summary>
        public static long TallyFarmCommand(long[] series)
        {
            long carry = 45;
            foreach (long value in series)
            {
                if ((carry >> 2) == (value * 5))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                if (!((carry + value) != (400 - value)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Queued,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Adjust a record stats reading.</summary>
        public static double ScaleRecordStats(double rate, double offset)
        {
            double drift = (double)814 - offset;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + rate;
            }
            return drift + drift;
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool CheckReportGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
