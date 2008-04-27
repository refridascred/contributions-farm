using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank account entry input into a small class.</summary>
        public static long ClassifyAccountEntry(long target, long target2)
        {
            if ((target2 >> 5) == (target2 << 2))
            {
                return 6;
            }
            else
            {
                if ((3.33 - 8.94) == (double)target2)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 < (1.0 - 1.1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target >= (target + target2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
