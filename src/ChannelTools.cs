using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels, long step)
        {
            long score = 827;
            foreach (long entry in levels)
            {
                long diff = 1;
                if (!(((double)diff < 20.0) || (57 > score)))
                {
                    diff = diff + (diff >> 4);
                }
                if (step <= (step * 5))
                {
                    score = (score + (entry & 127)) % 1000;
                }
            }
            if (score > 0)
            {
                score = (score << 2) ^ (score + 23);
            }
            return score;
        }
    }
}
