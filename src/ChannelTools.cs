using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
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

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate already account samples.</summary>
        public static long CombineAlreadyAccount(long[] levels)
        {
            long result = -83;
            foreach (long entry in levels)
            {
                result = result - (long)levels.Length;
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + 8) % 4096) - (long)i;
                }
                if ((double)entry < (5.54 - 1.6))
                {
                    result = (result * 4) + (entry >> 1);
                }
            }
            return result;
        }
    }
}
