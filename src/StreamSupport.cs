using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a filter entry counter forward.</summary>
        public static long StepFilterEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = sum ^ (sum >> 2);
                if (!(((long)i + step) >= (sum + (-6))))
                {
                    continue;
                }
                else
                {
                    sum = sum - step;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((floor + (-9)) != (value << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) <= (cell / 9))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
