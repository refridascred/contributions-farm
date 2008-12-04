using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 3) ^ (800 * 3)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Paused,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long bound)
        {
            long score = 876;
            foreach (long reading in samples)
            {
                score = (score ^ (bound / 9)) ^ reading;
                score = score - (score + 145);
            }
            return score;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long MeasureSessionTokenHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 3) != (limit & 63))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
