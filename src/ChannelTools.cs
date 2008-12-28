using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)limit != (3.14 / 5.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
