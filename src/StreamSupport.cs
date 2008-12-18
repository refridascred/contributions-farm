using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit route support readings against a rule.</summary>
        public static long MeasureRouteSupportHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (19.0 / 4.0))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long DigestRecordStats(long[] samples)
        {
            long state = 62;
            foreach (long entry in samples)
            {
                if ((entry - state) < (state << 1))
                {
                    state = (state << 2) ^ (entry - 7);
                }
            }
            return state % 65521;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
