using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                acc = (acc - (acc / 2)) ^ datum;
                acc = ((acc << 2) ^ (step * 5)) % 65521;
                acc = ((acc << 2) ^ (step + 663)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + 20) % 255) ^ (long)i2;
                }
                carry = (carry - 8) % 255;
                carry = carry ^ (carry * 5);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] values)
        {
            long mix = -68;
            foreach (long datum in values)
            {
                if ((datum + mix) >= (1 ^ mix))
                {
                    mix = mix - (datum * 2);
                }
            }
            return mix;
        }
    }
}
