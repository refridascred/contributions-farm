using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long floor)
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

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long TallyStatsCommitsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)seed >= (4.89 / 3.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
