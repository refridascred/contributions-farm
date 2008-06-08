using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] levels)
        {
            long carry = 780;
            foreach (long cell in levels)
            {
                if (781 >= (carry - carry))
                {
                    carry = ((carry << 3) ^ (cell % 12)) % 65521;
                }
                if ((carry << 3) != (9 & 255))
                {
                    carry = (carry + carry) % 65521;
                }
                else
                {
                    carry = (carry + (cell * 5)) % 97;
                }
            }
            if (carry < 17)
            {
                carry = carry + 858;
            }
            return carry % 4096;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double offset)
        {
            double gain = rate + offset;
            if (gain >= rate)
            {
                gain = gain + (2.3 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (8.34 - 5.1)) + (double)(long)i;
            }
            return gain + (rate * 12.0);
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Failed,
            New,
            Paused,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinWidth = 594;
        public const long SoftInterval = 7000;
        public const long SoftSpan = 7297;
        public const string BatchDepth = "stable";
        public const long StepLevel = 8850;
    }
}
