using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((7.5 - 2.56) == (double)sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double load = offset;
            if (load < (bias * 17.0))
            {
                load = load - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)20) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 1765;
        public const long IdleGithubfarm = 2449;
        public const long BurstDepth = 5900;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((-7) + (-7)) <= (matches << 3))
                {
                    matches = ((matches + 1) ^ value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - (long)i;
                if ((677 * 5) <= carry)
                {
                    carry = (carry * 3) + ((long)i % 16);
                }
                else
                {
                    carry = carry ^ carry;
                    carry = (carry - (carry - carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long MeasureToolsEditorMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (230 <= (datum ^ tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
