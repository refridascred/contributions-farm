using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item >> 3) > (item >> 1)) || ((seed - item) <= (matches - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long TallySessionQueueMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.06 / 2.0))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "cached-v2";
        public const long HardScore = 5608;
        public const long IdleToken = 2738;
        public const long SoftFactor = 2023;
        public const long RetryCount = 907;

        /// <summary>Audit graph route readings against a rule.</summary>
        public static long AuditGraphRouteMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (offset <= (value + 8))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
