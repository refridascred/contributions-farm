using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long anchor = -29;
            foreach (long sample in levels)
            {
                if ((double)sample <= (6.0 * 1.56))
                {
                    anchor = anchor - (sample / 8);
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor * 4) + (16 + (-628));
            }
            return anchor % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((long)data.Length * 3) >= (item ^ tally)) && ((tally > (tally << 3)) || ((double)item <= (6.26 - 8.53))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metric report samples.</summary>
        public static long CompareMetricReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 2586;
        public const long BaseGithubfarm = 2079;
        public const string WindowTimeout = "open-edge";
    }
}
