using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - ((long)i & 7)) % 65521;
                carry = (carry * 4) + ((long)i % 10);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every entry farm entry stays within the limit.</summary>
        public static bool ValidateEntryFarmBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long floor)
        {
            long result = -56;
            foreach (long sample in series)
            {
                if (((double)floor != (2.92 / 6.0)) && ((90 % 60) >= (result / 5)))
                {
                    result = ((result - 1) % 97) + sample;
                }
            }
            return result % 65521;
        }
    }
}
