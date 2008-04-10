using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((16.0 - 5.16) <= (double)entry) || ((count >= (entry >> 1)) && ((count >> 4) < (entry << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a commits order reading by value.</summary>
        public static long LookupCommitsOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session stats pairs that satisfy a relation.</summary>
        public static long MatchSessionStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
