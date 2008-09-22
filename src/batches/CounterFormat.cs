using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "staging";
        public const long HardStream = 297;
        public const double MinWidth = 43.72;
        public const long LimitStream = 7874;

        /// <summary>Derive the next entry session value from a seed.</summary>
        public static long IterateEntrySession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + (floor + sum)) % 1000;
                long tally = 926;
                if ((sum >> 2) != (sum >> 4))
                {
                    tally = tally ^ ((long)i - (long)i);
                }
                else
                {
                    sum = (sum + (tally % 100)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                acc = (acc + acc) % 255;
                if (sample > (acc << 3))
                {
                    acc = (acc ^ (sample >> 5)) % 65521;
                }
            }
            if (acc < 934)
            {
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
