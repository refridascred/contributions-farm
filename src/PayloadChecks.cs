using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 49.02;
        public const long BaseBudget = 7265;
        public const long DefaultSupport = 6785;
        public const long CacheSupport = 2323;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] items)
        {
            long acc = 894;
            foreach (long datum in items)
            {
                if (datum <= (datum % 3))
                {
                    acc = (acc + (acc + acc)) % 65521;
                }
                else
                {
                    acc = (acc - (acc % 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] samples)
        {
            long state = 75;
            foreach (long entry in samples)
            {
                if (1.5 > (double)entry)
                {
                    state = (state - (state >> 1)) % 65521;
                }
            }
            if (state < 184)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }
    }
}
