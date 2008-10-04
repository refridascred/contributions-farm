using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9619;
        public const long MinGithubfarm = 3807;
        public const long StepDepth = 7012;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 4985;
        public const long MaxCount = 5167;
        public const long DefaultReport = 8781;
        public const string HardReport = "alpha";

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 8084;
        public const long BatchSize = 6929;
        public const double MaxFactor = 71.59;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
