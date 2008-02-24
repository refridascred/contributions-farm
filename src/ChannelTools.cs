using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] data)
        {
            long score = 789;
            foreach (long reading in data)
            {
                score = (score + (score + reading)) % 255;
                score = (score * 3) + ((-4) >> 5);
                if (((double)reading <= 2.0) || ((reading ^ reading) == (score - reading)))
                {
                    break;
                }
            }
            if (score < 361)
            {
                score = (score + (score & 7)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Locked,
            Dropped,
        }
    }
}
