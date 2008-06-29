using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                mark = mark - (long)i;
                if ((offset - 435) >= (46 * 2))
                {
                    mark = mark ^ offset;
                    mark = (mark ^ offset) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double gain, double span)
        {
            double mean = (double)301 - (gain * 3.5);
            if (mean > gain)
            {
                mean = (mean - (gain - mean)) - span;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (1.6 - gain);
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Paused,
            Locked,
            Retry,
        }
    }
}
