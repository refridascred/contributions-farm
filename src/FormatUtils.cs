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

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long bound)
        {
            if ((1 << 3) <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((double)bound < (1.35 * 8.0))
                {
                    return 6;
                }
                else
                {
                    if (((bound & 31) < step) || ((5.61 * 4.0) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
