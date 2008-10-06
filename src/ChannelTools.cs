using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                double rate = (double)(1 ^ anchor);
                if (anchor > (long)i)
                {
                    rate = rate + (double)4;
                    continue;
                }
                if ((double)seed >= rate)
                {
                    anchor = anchor + (anchor + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long carry = 475;
            foreach (long datum in values)
            {
                carry = ((carry * 2) + datum) % 4096;
                carry = (carry * 2) + carry;
                if ((datum + 34) == (carry - (long)values.Length))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
