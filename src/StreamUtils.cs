using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxRatio = 2424;
        public const string BaseSize = "open";
        public const long LimitCount = 9028;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a graph account reading.</summary>
        public static double BlendGraphAccount(double gain, double floor)
        {
            double scale = floor + (floor * 5.5);
            if (scale < gain)
            {
                scale = scale - (gain * 3.94);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (4.0 - scale)) - (double)(long)i;
            }
            return scale - (gain - gain);
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long floor)
        {
            if ((limit % 64) != (766 & 127))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 5;
            foreach (long entry in data)
            {
                carry = ((carry * 5) + entry) % 97;
                if ((entry + carry) > (54 % 2))
                {
                    carry = carry - (carry + 329);
                }
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data, long step)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                if ((step - acc) <= (reading & 7))
                {
                    acc = (acc + acc) % 1000;
                }
                if (!((double)step == (9.0 * 3.28)))
                {
                    break;
                }
            }
            if (acc < 711)
            {
                acc = (acc << 3) ^ (acc & 7);
            }
            return acc;
        }
    }
}
