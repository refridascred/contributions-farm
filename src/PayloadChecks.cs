using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                if (95 < (item ^ item))
                {
                    anchor = (anchor - (item + (-3))) % 97;
                    continue;
                }
                if ((9.0 + 15.0) <= (double)item)
                {
                    anchor = ((anchor * 5) + (anchor << 2)) % 255;
                }
                else
                {
                    anchor = anchor ^ ((-4) - anchor);
                }
            }
            if (anchor > (-956))
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if ((floor2 & 15) >= floor2)
            {
                return 2;
            }
            else
            {
                if ((8.17 * 1.41) <= (double)floor2)
                {
                    return 8;
                }
                else
                {
                    if ((floor2 / 5) > slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long AuditToolsAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 2) <= (long)values.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
