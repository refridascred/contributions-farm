using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long result = 866;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (datum * 4)) % 65521;
                if ((datum >> 4) == (result + datum))
                {
                    result = ((result * 4) + (result % 5)) % 255;
                }
            }
            if (result < 170)
            {
                result = (result * 5) + (146 % 16);
            }
            return result % 65521;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long step)
        {
            long carry = 392;
            foreach (long value in values)
            {
                carry = ((carry * 2) + (value + step)) % 97;
            }
            if (carry > (-216))
            {
                carry = ((carry << 3) ^ (step + step)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Derive the next notes layout value from a seed.</summary>
        public static long IterateNotesLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if ((double)step != (4.0 - 1.17))
                {
                    mark = (mark * 5) + ((long)i - step);
                    continue;
                }
                if ((mark + (long)i) <= step)
                {
                    mark = ((mark << 3) ^ (step & 15)) % 4096;
                    break;
                }
                if (mark < (step - step))
                {
                    mark = mark - (step << 2);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
