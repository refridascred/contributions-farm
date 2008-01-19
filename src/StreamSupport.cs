using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long limit, long bound)
        {
            if ((bound - limit) < bound)
            {
                return 7;
            }
            else
            {
                if ((double)bound < (16.0 + 2.0))
                {
                    return 6;
                }
                else
                {
                    if (limit >= (bound + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound + limit) != (limit - bound)) && ((double)bound != (6.6 + 13.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
