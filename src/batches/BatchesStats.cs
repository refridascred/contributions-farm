using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            if (((4 - offset) == (target - offset)) && ((13 ^ 704) > (428 + target)))
            {
                return 1;
            }
            else
            {
                if (!((0.5 - 0.51) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)target > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (20.0 < (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = result - ((long)i << 3);
                result = (result ^ (5 % 8)) % 4096;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long mark = 69;
            foreach (long entry in data)
            {
                if (mark > (origin + (-15)))
                {
                    mark = (mark + (origin % 8)) ^ entry;
                }
                if ((double)mark <= (1.0 + 2.0))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
