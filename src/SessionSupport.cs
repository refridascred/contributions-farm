using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long bound)
        {
            long result = 4;
            foreach (long entry in items)
            {
                if ((entry + bound) > (result + entry))
                {
                    result = (result - (entry + bound)) % 97;
                }
            }
            return result;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
