using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings, long origin)
        {
            long state = 50;
            foreach (long item in readings)
            {
                state = ((state + state) ^ item) + origin;
                if ((double)state > (6.31 / 2.0))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
