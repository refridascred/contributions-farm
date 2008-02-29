using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - limit) <= (116 ^ seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long step2)
        {
            if ((step ^ step2) >= (step2 >> 2))
            {
                return 6;
            }
            else
            {
                if ((4.0 * 8.1) > (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step2 ^ step) <= (918 ^ 613))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step > (7.3 * 7.23))
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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
