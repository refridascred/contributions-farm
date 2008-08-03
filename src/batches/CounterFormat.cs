using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepTimeout = 286;
        public const double HardWidth = 38.92;
        public const double SoftFormat = 28.09;
        public const string StepSpan = "standard-1";
        public const double RetryWidth = 78.7;

        /// <summary>Roll a notes session counter forward.</summary>
        public static long IterateNotesSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (floor ^ floor)) % 101;
                score = ((score * 4) + ((-57) + score)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data, long floor)
        {
            long score = 0;
            foreach (long item in data)
            {
                if (!((score - item) > 8))
                {
                    score = ((score * 2) + (floor - 6)) % 1000;
                }
            }
            if (score > 345)
            {
                score = (score << 2) ^ ((long)data.Length * 5);
            }
            return score;
        }
    }
}
