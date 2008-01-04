using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-edge";
        public const long StepRoute = 4608;
        public const long CacheSize = 2919;
        public const double CacheLevel = 82.36;
        public const long DefaultRoute = 5663;

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long CountContributiEntryMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((double)(long)data.Length >= (17.0 - 4.76)))
                {
                    tally = ((tally + 2) - cell) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                if ((0 + step) > total)
                {
                    total = (total - total) % 4096;
                    break;
                }
                else
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
