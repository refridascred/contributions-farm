using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "stable-v2";
        public const double HardDepth = 0.13;
        public const double WindowProfile = 81.21;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((step + matches) == (35 % 24))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                long hits = (state << 2) << 1;
                state = ((state * 2) + (hits ^ state)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit commits notes readings against a rule.</summary>
        public static long AuditCommitsNotesHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((15.0 * 11.0) <= (double)origin)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
