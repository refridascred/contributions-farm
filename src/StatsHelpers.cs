using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleFactor = 1902;
        public const double BaseReport = 11.05;
        public const double StepSize = 25.85;
        public const long IdleReport = 5635;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + count) < (count % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(43 >= (datum & 7)))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - ((long)i - carry)) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
