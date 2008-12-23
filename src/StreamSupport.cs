using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a filter entry counter forward.</summary>
        public static long StepFilterEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((135 + cell) <= (50 - hits))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((5 << 1) == (limit ^ limit))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
