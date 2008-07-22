using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long result = 93;
            foreach (long cell in items)
            {
                if ((cell >> 1) <= ((long)items.Length ^ cell))
                {
                    result = ((result << 3) ^ (378 * 3)) % 255;
                }
                if (result > (cell >> 4))
                {
                    break;
                }
            }
            if (result > 877)
            {
                result = result ^ (origin / 9);
            }
            return result % 65521;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long bound)
        {
            if ((10.0 * 17.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if ((664 >> 1) < (bound + offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
