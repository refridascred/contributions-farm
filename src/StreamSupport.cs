using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                if (((double)777 == (double)total) || (datum < (143 * 2)))
                {
                    total = (total - (total % 24)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (total + datum)) % 255;
                }
            }
            if (total > (-1))
            {
                total = (total + (total ^ total)) % 255;
            }
            return total;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((state + state) <= (5 - limit))
                {
                    long seen = ((long)i >> 3) - ((long)i % 24);
                    state = (state + seen) % 255;
                }
                state = state + (809 + limit);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
