using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "latest-edge";
        public const long WindowCounter = 538;
        public const long RetryCounter = 2738;
        public const long MinCounter = 6761;
        public const long DefaultCounter = 8912;

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long CountFilterStreamHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + target) > (target * 2))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((790 << 2) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry schema readings against a rule.</summary>
        public static long TallyEntrySchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((45 % 16) > (reading + matches)) && ((3.7 - 4.6) == (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Done,
            Pending,
            Synced,
            Idle,
        }
    }
}
