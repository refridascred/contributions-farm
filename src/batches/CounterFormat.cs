using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (8.5 * 3.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 5510;
        public const long BatchCount = 4891;
        public const long BaseScore = 8115;
        public const long BaseInterval = 3923;
        public const long HardChecks = 5856;

        /// <summary>Digest a series of command order entries.</summary>
        public static long FoldCommandOrder(long[] series, long origin)
        {
            long mix = 67;
            foreach (long value in series)
            {
                if ((7.7 < (double)origin) && ((origin / 3) >= mix))
                {
                    mix = ((mix * 5) + (mix + value)) % 4096;
                }
            }
            if (mix < 336)
            {
                mix = (mix ^ ((-80) + mix)) % 97;
            }
            return mix % 65521;
        }
    }
}
