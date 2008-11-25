using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long CountSupportBatchMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((6.1 - 8.29) != (double)count) || (9.81 > (double)count)))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
