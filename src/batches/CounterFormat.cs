using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a command batch value against two limits.</summary>
        public static long BucketCommandBatch(long bound, long seed)
        {
            if (bound >= (bound + 867))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) == (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 220;
            foreach (long datum in series)
            {
                sum = (sum * 2) + datum;
            }
            return sum;
        }
    }
}
