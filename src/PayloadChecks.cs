using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long limit)
        {
            long acc = 253;
            foreach (long datum in levels)
            {
                acc = ((acc + (datum & 255)) % 101) - limit;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleSize = 5236;
        public const string HardSpan = "staging-v2";
        public const double MaxRoute = 38.84;
        public const long DefaultRoute = 5012;
        public const long HardRoute = 8843;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long bound, long seed)
        {
            if ((bound + seed) >= (bound + 17))
            {
                return 5;
            }
            else
            {
                if (!(seed < (bound + seed)))
                {
                    return 8;
                }
                else
                {
                    if (19.0 <= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftBudget = "local-v2";
        public const long HardScore = 8909;
        public const long MaxFactor = 2124;
    }
}
