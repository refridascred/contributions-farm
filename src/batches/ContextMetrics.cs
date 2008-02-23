using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series, long step)
        {
            long score = -860;
            foreach (long datum in series)
            {
                if ((double)score > (double)8)
                {
                    score = ((score + score) ^ datum) + step;
                }
                else
                {
                    score = ((score * 4) + score) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSpan = 9868;
        public const long MinChecks = 8982;
        public const long CacheScore = 3600;
        public const long LimitFactor = 6200;
        public const long BurstSize = 4096;

        /// <summary>Find the first report buffer entry that matches the target.</summary>
        public static long LookupReportBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry channel readings against a rule.</summary>
        public static long AuditEntryChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - (-848)) > sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
