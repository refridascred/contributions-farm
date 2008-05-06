using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data)
        {
            long score = 9;
            foreach (long reading in data)
            {
                if (((score ^ reading) == (37 - 4)) && ((double)score >= (5.3 - 8.5)))
                {
                    score = (score << 2) ^ (score - score);
                }
                if ((reading + score) < reading)
                {
                    score = (score - (reading / 4)) % 101;
                }
            }
            if (score > 94)
            {
                score = (score + score) % 65521;
            }
            return score;
        }
    }
}
