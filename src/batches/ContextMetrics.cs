using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Failed,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long offset)
        {
            if (((double)offset >= (double)66) || ((5.41 / 8.0) != (double)origin))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (9.88 - 5.6))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool ValidateChannelFarmLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
