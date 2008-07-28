using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue command samples.</summary>
        public static long ScoreQueueCommand(long[] series)
        {
            long anchor = 708;
            foreach (long reading in series)
            {
                if (!((anchor ^ (-7)) != (anchor ^ reading)))
                {
                    anchor = (anchor * 3) + (reading % 2);
                }
                else
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long DeriveSchemaAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate schema account readings against a bound.</summary>
        public static bool GuardSchemaAccountBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 7779;
        public const long BurstSize = 2809;
        public const string DefaultContributi = "fallback-v2";
        public const long RetryContributi = 3656;
    }
}
