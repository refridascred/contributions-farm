using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a commits graph reading by value.</summary>
        public static long SeekCommitsGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
