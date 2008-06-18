using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((target / 9) > (target - matches)) && ((2 * 5) >= (value - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank format editor input into a small class.</summary>
        public static long ClassifyFormatEditor(long floor, long seed)
        {
            long diff = floor + seed;
            if (!((floor + seed) == (seed % 7)))
            {
                return 3;
            }
            else
            {
                if ((floor & 15) != (diff + seed))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 9313;
        public const long BaseChecks = 7937;
        public const long MinChecks = 5069;
    }
}
