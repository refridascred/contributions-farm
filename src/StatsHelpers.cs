using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits > (20.0 + 3.93))
                {
                    hits = ((hits + 3) ^ item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count schema stream pairs that satisfy a relation.</summary>
        public static long MatchSchemaStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen ^ seen) > sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up notes cluster samples.</summary>
        public static long OverlapNotesClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
