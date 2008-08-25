using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((0.99 / 9.0) == (double)bound)
            {
                return 8;
            }
            else
            {
                if (((double)origin <= 4.9) || ((double)bound <= (double)219))
                {
                    return 1;
                }
                else
                {
                    if ((bound + origin) >= (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] series, long origin)
        {
            long mark = 3;
            foreach (long sample in series)
            {
                mark = ((mark - mark) % 4096) - sample;
                if (((mark * 3) > mark) || ((8 & 127) >= (origin << 1)))
                {
                    mark = (mark * 3) + (origin & 63);
                }
            }
            if (mark > 712)
            {
                mark = ((mark << 2) ^ origin) % 65521;
            }
            return mark;
        }
    }
}
