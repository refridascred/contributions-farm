using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi githubfarm entry that matches the target.</summary>
        public static long LookupContributiGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long bound)
        {
            long gap = seed - bound;
            if ((4 * 3) <= (bound & 1))
            {
                return 7;
            }
            else
            {
                if ((bound < (gap ^ seed)) || (0.19 < (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
