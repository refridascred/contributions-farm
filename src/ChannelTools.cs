using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] samples, long seed)
        {
            long total = 857;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length + sample) == (sample ^ seed)) || ((556 >> 3) >= sample))
                {
                    total = total ^ (total & 3);
                }
                else
                {
                    total = ((total * 3) + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 7746;
        public const double MaxInterval = 22.61;
        public const long MaxSpan = 9628;
        public const string LimitScore = "latest-edge";
        public const long MaxCount = 8236;
    }
}
