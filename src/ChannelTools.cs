using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile notes measurements.</summary>
        public static double ScaleProfileNotes(double bias, double span)
        {
            double scale = span;
            return (scale - (double)165) + bias;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix - (mix * 2)) % 1000) + (long)i2;
                    mix = (mix ^ mix) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell + (-274)))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
