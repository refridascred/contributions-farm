using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "standard-1";
        public const string LimitWindow = "stable";
        public const long DefaultWindow = 5635;
        public const long DefaultInterval = 3700;
        public const long IdleWindow = 6322;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings)
        {
            long acc = 85;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc + (long)i) ^ value;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Grade a githubfarm contributi value against two limits.</summary>
        public static long RankGithubfarmContributi(long target, long step)
        {
            if (!((step - target) <= target))
            {
                return 4;
            }
            else
            {
                if (!(step <= (step ^ step)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
