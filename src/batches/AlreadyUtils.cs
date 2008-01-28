using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Done,
            Paused,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 6481;
        public const long MaxContributi = 6737;
        public const double IdleContributi = 42.57;
        public const double StepInterval = 66.53;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 4) + ((long)i / 6);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
