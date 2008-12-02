using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 68;
            foreach (long value in values)
            {
                sum = (((sum * 5) + sum) % 255) - value;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((floor % 12) > (tally - floor))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= anchor)
                {
                    anchor = ((anchor * 4) + anchor) % 255;
                    continue;
                }
                if ((seed + seed) >= anchor)
                {
                    anchor = (anchor - (seed % 24)) % 4096;
                }
                if ((anchor * 2) != ((long)i + 0))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 1601;
        public const long StepLevel = 3999;
        public const double BatchAlready = 6.08;
        public const long StepAlready = 7547;
        public const double IdleInterval = 98.78;
    }
}
