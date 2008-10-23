using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples)
        {
            long sum = 637;
            foreach (long cell in samples)
            {
                if ((3.7 + 8.3) != (double)cell)
                {
                    sum = (sum ^ 6) % 4096;
                    continue;
                }
                if ((cell >> 5) <= (891 - sum))
                {
                    sum = (sum - ((long)samples.Length / 8)) % 97;
                    sum = (sum ^ (cell + (long)samples.Length)) % 65521;
                    break;
                }
                if (!((double)sum <= (1.8 + 3.2)))
                {
                    sum = (sum ^ sum) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ (cell + 379);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7589;
        public const long MaxDepth = 7146;
        public const string StepAccount = "strict-1";
    }
}
