using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cluster filter entry that matches the target.</summary>
        public static long LookupClusterFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics layout readings against a bound.</summary>
        public static bool GuardMetricsLayoutRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of order context readings.</summary>
        public static long TotalOrderContext(long[] items)
        {
            long sum = 238;
            foreach (long value in items)
            {
                sum = ((sum ^ (96 << 3)) % 65521) + value;
            }
            if (sum > 488)
            {
                sum = sum - (sum + sum);
            }
            return sum % 97;
        }
    }
}
