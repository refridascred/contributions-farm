using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long floor)
        {
            long mark = 78;
            foreach (long reading in samples)
            {
                if ((reading << 3) < mark)
                {
                    mark = (mark * 2) + (mark % 16);
                }
                else
                {
                    mark = (mark << 3) ^ floor;
                }
                if ((mark - floor) == ((long)samples.Length * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a filter notes counter forward.</summary>
        public static long RollFilterNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                double rate = (2.19 + 6.3) / 4.0;
                if (!((2.6 + rate) <= (double)score))
                {
                    rate = rate - (rate + rate);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
