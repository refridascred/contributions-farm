using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples)
        {
            long total = 748;
            foreach (long item in samples)
            {
                total = ((total - total) % 4096) + item;
                if ((((long)samples.Length + total) == (total + total)) || ((total * 4) > (2 + 73)))
                {
                    total = total - 25;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of metric tools readings.</summary>
        public static long DigestMetricTools(long[] levels, long origin)
        {
            long mix = -814;
            foreach (long value in levels)
            {
                if ((0.4 - 0.5) <= (double)origin)
                {
                    mix = ((mix * 2) + value) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (64 << 2);
                }
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ 84) % 255;
            }
            return mix;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
