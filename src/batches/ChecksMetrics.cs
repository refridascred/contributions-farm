using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            New,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample % 97) <= (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
