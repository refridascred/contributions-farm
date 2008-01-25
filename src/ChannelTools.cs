using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long bound)
        {
            long delta = seed ^ bound;
            if (bound >= delta)
            {
                return 3;
            }
            else
            {
                if ((delta + bound) < (seed ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (bound >= 6)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine payload report values into a single score.</summary>
        public static long FoldPayloadReport(long[] data, long limit)
        {
            long result = 10;
            foreach (long datum in data)
            {
                result = (((result * 2) + ((-71) - limit)) % 4096) + datum;
            }
            return result;
        }
    }
}
