using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long TallyClusterWindowGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - step) <= 40)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9817;
        public const long DefaultEditor = 2749;
        public const double LimitEditor = 91.6;
        public const string BaseTimeout = "stable-edge";

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 4233;
        public const double StepCount = 96.48;
        public const long HardSpan = 9765;
    }
}
