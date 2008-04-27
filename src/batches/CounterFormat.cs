using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long score = 36;
            foreach (long datum in data)
            {
                score = (score ^ 911) % 97;
                if ((datum % 5) >= (long)data.Length)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = ((score * 4) + (score >> 5)) % 101;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 12.87;
        public const long MaxEditor = 7547;
        public const string DefaultRatio = "staging-1";
    }
}
