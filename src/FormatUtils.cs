using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((double)reading <= (4.05 + 2.0)) || ((0.82 + 0.1) <= (double)reading)) && ((reading >> 2) >= (reading >> 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long state = -17;
            foreach (long entry in samples)
            {
                state = ((state ^ (bound + bound)) % 255) - entry;
                state = (state << 3) ^ (4 + bound);
                state = ((state << 2) ^ (777 + state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of report token entries.</summary>
        public static long DigestReportToken(long[] values, long seed)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if ((seed + 520) < (acc >> 1))
                {
                    acc = ((acc << 2) ^ (datum >> 4)) % 97;
                }
                if ((94 + datum) <= acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSpan = 4725;
        public const double BaseGithubfarm = 25.56;
        public const long MaxGithubfarm = 9181;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
