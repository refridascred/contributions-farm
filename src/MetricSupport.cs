using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of session format readings.</summary>
        public static long TallySessionFormat(long[] items, long step)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                anchor = (anchor + (anchor & 7)) - step;
                if ((anchor < (datum - anchor)) && ((39 >> 1) >= datum))
                {
                    anchor = (anchor - (0 >> 4)) % 255;
                }
                else
                {
                    anchor = anchor - (anchor << 1);
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepLevel = "strict-v2";
        public const double CacheScore = 46.48;
        public const long IdleWidth = 8680;

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long offset)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                if ((offset <= (9 + carry)) && ((sample >> 5) <= sample))
                {
                    carry = (carry * 2) + (77 >> 1);
                }
            }
            if (carry < 2)
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }
    }
}
