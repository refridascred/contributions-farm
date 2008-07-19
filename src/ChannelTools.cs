using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long step)
        {
            long carry = 9;
            foreach (long cell in samples)
            {
                carry = ((carry - (cell + 93)) % 255) - step;
            }
            if (carry < 0)
            {
                carry = (carry + (carry % 24)) % 4096;
            }
            return carry;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
