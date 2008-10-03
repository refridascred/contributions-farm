using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Match up metrics cluster samples.</summary>
        public static long PairMetricsClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a session format reading by value.</summary>
        public static long LocateSessionFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (result / 7)) % 1000;
                result = (result * 5) + 319;
                result = (result - (857 - result)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 13.62;
        public const long BurstWindow = 4534;
        public const long BaseBudget = 8345;
    }
}
