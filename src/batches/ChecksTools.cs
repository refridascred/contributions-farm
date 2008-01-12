using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many githubfarm channel samples are out of range.</summary>
        public static long AuditGithubfarmChannelGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)origin == (double)65) && ((tally > (origin % 100)) && (99 < ((long)values.Length >> 5))))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit notes entry readings against a rule.</summary>
        public static long MeasureNotesEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen ^ 731) >= (seen << 2)) && ((entry - seen) >= (seen + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((step * 2) >= (tally >> 4)) && (entry > tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
