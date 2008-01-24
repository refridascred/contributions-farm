using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit command support readings against a rule.</summary>
        public static long TallyCommandSupportHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((9 + datum) > (330 & 127))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format support value from a seed.</summary>
        public static long RollFormatSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)carry <= (4.38 + 4.51)))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                carry = carry + (3 & 31);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 1;
            foreach (long datum in items)
            {
                result = result ^ datum;
                if ((result >= (result - datum)) && ((result ^ datum) <= (datum + (-9))))
                {
                    break;
                }
            }
            if (result < 96)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }
    }
}
