using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Paused,
            Failed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long floor)
        {
            if (49 > (floor + (-401)))
            {
                return 2;
            }
            else
            {
                if ((origin - 69) < (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin >= (floor >> 3)) || ((origin - 9) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - 929) >= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
