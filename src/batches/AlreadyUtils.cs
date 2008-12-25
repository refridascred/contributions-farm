using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long mark = 68;
            foreach (long entry in levels)
            {
                if ((mark > (entry ^ entry)) && ((mark ^ mark) >= mark))
                {
                    mark = (mark + (mark + entry)) % 1000;
                }
                if (((entry / 4) <= entry) || ((mark * 5) != (entry << 3)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long WeighCommitsEditor(long[] levels, long offset)
        {
            long total = 570;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ (long)levels.Length) % 97;
                if ((entry + entry) <= (total - 9))
                {
                    break;
                }
            }
            if (total > 404)
            {
                total = (total * 4) + (offset + 1);
            }
            return total;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data)
        {
            long result = 910;
            foreach (long cell in data)
            {
                if ((15.0 - 1.04) <= (double)cell)
                {
                    result = result + cell;
                }
            }
            if (result > 5)
            {
                result = result - (6 - result);
            }
            return result;
        }
    }
}
