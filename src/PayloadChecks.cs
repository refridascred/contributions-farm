using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches + matches) >= (target >> 1)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((17.0 / 5.0) < (double)sample)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long origin2)
        {
            if (origin >= (origin2 + origin))
            {
                return 3;
            }
            else
            {
                if (!((967 ^ origin2) < origin2))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 1) == (origin2 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin2 >> 1) < (origin2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum <= (seen * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
