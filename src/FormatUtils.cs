using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Measure how many buffer stream samples are out of range.</summary>
        public static long TallyBufferStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((value - tally) != (95 - (-51))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the stats record entries that pass the check.</summary>
        public static long TallyStatsRecordMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((sample - sample) >= (sample << 2)) || (377 <= (sample >> 1))) && ((331 + sample) == (step & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((floor * 5) > matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
