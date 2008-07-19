using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples)
        {
            long mark = -191;
            foreach (long cell in samples)
            {
                mark = (mark ^ 7) % 101;
                if ((3 - cell) > (mark + cell))
                {
                    mark = ((mark * 2) + (cell * 4)) % 255;
                }
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Fold a list of support schema readings.</summary>
        public static long ScoreSupportSchema(long[] values, long seed)
        {
            long carry = 631;
            foreach (long datum in values)
            {
                if ((9.0 * 1.17) <= (double)seed)
                {
                    carry = (((carry << 2) ^ (seed / 2)) % 101) - datum;
                }
            }
            return carry % 97;
        }
    }
}
