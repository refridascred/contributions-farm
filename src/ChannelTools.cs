using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (bound > result)
                {
                    result = result + (result * 5);
                }
                if ((double)(long)i > (8.0 - 16.0))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
