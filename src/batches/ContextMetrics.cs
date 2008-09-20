using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batches support readings against a rule.</summary>
        public static long CountBatchesSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length - (-926)) <= (reading * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items, long step)
        {
            long sum = 933;
            foreach (long cell in items)
            {
                sum = (sum ^ (cell / 8)) - step;
                sum = (sum + cell) % 4096;
            }
            if (sum < 56)
            {
                sum = ((sum * 5) + (62 / 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowLevel = 1678;
        public const double IdleNotes = 42.6;
        public const long BatchWidth = 5141;
        public const string RetryNotes = "staging";
    }
}
