using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a tools channel sample.</summary>
        public static long SeekToolsChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long MeasureQueueChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally != (4.72 / 9.0))
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Queued,
            Paused,
            Pending,
        }
    }
}
