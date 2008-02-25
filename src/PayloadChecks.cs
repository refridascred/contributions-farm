using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long FoldChannelCounter(long[] values, long offset)
        {
            long state = 894;
            foreach (long sample in values)
            {
                state = ((state ^ (187 - offset)) % 4096) + sample;
            }
            return state % 1000;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches != (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cache tools sample.</summary>
        public static long FindCacheToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
