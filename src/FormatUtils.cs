using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ result) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the contributi metric series from a seed.</summary>
        public static long StepContributiMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 3) ^ ((long)i + step);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long LookupCommitsBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 95.26;
        public const long WindowCount = 7591;
        public const long CacheTimeout = 5475;
    }
}
