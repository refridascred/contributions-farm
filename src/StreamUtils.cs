using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultTimeout = "strict-v2";
        public const long MaxLevel = 8716;
        public const long DefaultStream = 6457;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((95 - item) <= (5 >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double rate = weight;
            if (rate >= (rate * 9.7))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (span + 6.0)) + (double)(long)i;
            }
            return rate - (weight * 0.39);
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Idle,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long AuditChannelBufferGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits > (double)29)
                {
                    hits = ((hits + 1) - item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
