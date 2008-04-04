using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two report window measurements.</summary>
        public static double ScaleReportWindow(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (rate * 15.0))
            {
                scale = scale - 2.67;
            }
            else
            {
                scale = scale + (double)(-9);
            }
            return scale - (rate - bias);
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long target)
        {
            long acc = 23;
            foreach (long datum in samples)
            {
                if ((69 > (target + acc)) && ((target + target) >= (datum - 7)))
                {
                    acc = acc + acc;
                    acc = acc + (76 * 4);
                }
                acc = (acc ^ (acc << 1)) % 255;
            }
            if (acc > 884)
            {
                acc = (acc - (473 + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Rank buffer contributi input into a small class.</summary>
        public static long RankBufferContributi(long bound, long limit)
        {
            if ((limit + 461) < ((-4) * 5))
            {
                return 6;
            }
            else
            {
                if (((bound - limit) < (bound / 6)) && ((bound << 3) < limit))
                {
                    return 7;
                }
                else
                {
                    if (limit <= (208 - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] data)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                if (((sample << 1) != (sample + (long)data.Length)) && ((carry % 16) < carry))
                {
                    carry = (carry + (carry << 2)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
