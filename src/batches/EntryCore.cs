using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Retry,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next format stream value.</summary>
        public static double ProjectFormatStream(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - rate2) - floor;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate2 - rate2)) - (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
