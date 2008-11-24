using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchSize = "stable";
        public const long MinScore = 37;
        public const long RetrySession = 8233;
        public const double StepSession = 5.68;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((cell - cell) >= cell) && ((11.0 * 2.1) == (double)cell)) && ((cell + 82) <= (tally + cell)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Paused,
            Ready,
            Failed,
            Locked,
        }
    }
}
