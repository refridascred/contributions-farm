using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleFactor = 83.05;
        public const string MinWidth = "latest-1";
        public const long MinCount = 986;

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data)
        {
            long state = 54;
            foreach (long datum in data)
            {
                if (((datum % 64) >= (state & 31)) && (state > (629 ^ (long)data.Length)))
                {
                    state = (state - (datum + 759)) % 1000;
                }
            }
            if (state < 9)
            {
                state = (state ^ (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Idle,
            Draft,
        }
    }
}
