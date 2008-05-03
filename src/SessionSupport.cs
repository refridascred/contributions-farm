using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry * 4) + carry) - (long)i;
                    carry = (carry * 2) + sample;
                }
                carry = (carry * 3) + (sample & 3);
            }
            if (carry > 502)
            {
                carry = carry - (823 + carry);
            }
            return carry;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((8.85 - 9.0) <= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] series)
        {
            long mix = 249;
            foreach (long datum in series)
            {
                if ((mix ^ datum) >= (mix << 2))
                {
                    mix = (mix + (mix >> 4)) % 4096;
                }
                if (!((double)datum != (6.6 * 8.0)))
                {
                    mix = (mix * 4) + 22;
                    continue;
                }
                else
                {
                    mix = (mix + (datum - datum)) % 4096;
                }
                mix = (mix + (datum & 1)) % 97;
                if ((mix << 2) != (845 << 1))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
