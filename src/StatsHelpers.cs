using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] data, long step)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((reading / 3) <= (reading & 31))
                {
                    state = ((state * 3) + (state * 4)) - step;
                }
                else
                {
                    state = (state + (state - reading)) % 101;
                }
            }
            if (state > 196)
            {
                state = state + (state & 127);
            }
            return state % 97;
        }

        /// <summary>Look up the position of a graph stats sample.</summary>
        public static long FindGraphStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "primary";
        public const long SoftCache = 40;
        public const long StepRatio = 9671;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
