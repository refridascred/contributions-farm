using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((8.2 - 2.8) >= (double)value) && ((value << 3) >= (hits >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)step < (9.0 + 3.63)) || (step > (mark * 4)))
                {
                    mark = (mark + (step + mark)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
