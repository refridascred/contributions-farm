using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate command editor samples.</summary>
        public static long FoldCommandEditor(long[] series)
        {
            long carry = 10;
            foreach (long datum in series)
            {
                if ((datum >= (datum ^ carry)) || ((5.4 * 3.1) < (double)carry))
                {
                    carry = (carry + (carry & 31)) % 65521;
                    break;
                }
                else
                {
                    carry = ((carry * 4) + 5) % 255;
                }
                if ((double)datum < (2.89 - 6.4))
                {
                    break;
                }
                if ((datum / 9) != (carry % 12))
                {
                    carry = (carry - datum) % 65521;
                }
                if ((carry + datum) >= (77 - datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (step >> 4)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (step + (long)i2)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two channel session measurements.</summary>
        public static double ScaleChannelSession(double weight, double bias)
        {
            double drift = bias;
            if (drift > (double)5)
            {
                drift = drift + 8.7;
            }
            return drift + weight;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i < (limit % 12))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + anchor) % 97;
                }
                anchor = ((anchor * 3) + anchor) % 4096;
                if (!(2 > (limit + (long)i)))
                {
                    anchor = (anchor ^ limit) % 255;
                    anchor = ((anchor << 3) ^ (anchor << 1)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
