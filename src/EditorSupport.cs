using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double weight, double span)
        {
            double scale = span - (2.0 / 3.0);
            if (scale < (weight - 13.0))
            {
                scale = scale + (span + span);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale - 0.38)) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstScore = 9636;
        public const long SoftRoute = 7188;
        public const long MinRoute = 1451;
        public const string HardRoute = "primary";
        public const long HardTimeout = 5258;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (double)(-99))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + 0) >= (matches - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
