using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate channel profile samples.</summary>
        public static long ScoreChannelProfile(long[] readings, long seed)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                total = ((((total * 3) + (long)readings.Length) % 97) - reading) - seed;
            }
            if (total > 17)
            {
                total = (total ^ (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item >= (item >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph already readings.</summary>
        public static long MatchGraphAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
