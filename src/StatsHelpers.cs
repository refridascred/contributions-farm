using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels)
        {
            long state = 0;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (state - state)) % 65521;
                state = (state ^ (datum + 73)) % 1000;
            }
            return state % 4096;
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
