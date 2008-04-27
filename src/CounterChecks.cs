using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up commits window samples.</summary>
        public static long MatchCommitsWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route farm values into a single score.</summary>
        public static long DigestRouteFarm(long[] data, long floor)
        {
            long mark = 2;
            foreach (long item in data)
            {
                mark = (mark << 2) ^ (item ^ 8);
            }
            if (mark < 250)
            {
                mark = (mark * 4) + floor;
            }
            return mark % 4096;
        }

        /// <summary>Audit editor notes readings against a rule.</summary>
        public static long AuditEditorNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (value << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Fold a list of githubfarm contributi readings.</summary>
        public static long FoldGithubfarmContributi(long[] series)
        {
            long anchor = 5;
            foreach (long entry in series)
            {
                anchor = anchor - anchor;
                if (((double)anchor == (14.0 / 4.0)) && ((entry - entry) == (entry << 2)))
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor;
        }
    }
}
