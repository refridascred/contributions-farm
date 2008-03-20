using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Locate a profile counter reading by value.</summary>
        public static long LocateProfileCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                acc = (acc - (acc ^ bound)) % 4096;
                if (bound <= 58)
                {
                    acc = acc - (item >> 3);
                }
            }
            return acc;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
