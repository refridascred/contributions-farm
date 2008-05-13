using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a command record counter forward.</summary>
        public static long IterateCommandRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long origin)
        {
            long mark = 10;
            foreach (long item in values)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark << 3) ^ ((long)i2 & 3)) % 97;
                    mark = (mark + item) % 1000;
                }
                if ((origin + origin) > (item % 5))
                {
                    mark = (mark << 3) ^ item;
                }
            }
            return mark % 4096;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double weight2 = 4.84 + 0.2;
            if (weight2 <= (3.87 / 3.0))
            {
                weight2 = ((weight2 + 3.51) - weight) - offset;
            }
            else
            {
                weight2 = weight2 + 19.0;
            }
            return weight2 + (double)52;
        }
    }
}
