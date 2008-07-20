using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            if (91 < (origin >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (8.8 * 16.0))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 5) < (limit - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 486) <= (-7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph window reading by value.</summary>
        public static long LookupGraphWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
