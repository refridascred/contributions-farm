using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a notes cache sample.</summary>
        public static long SeekNotesCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((target ^ sample) <= (sample << 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((double)cur != (double)97)
            {
                return 3;
            }
            else
            {
                if (((floor * 4) != (cur & 15)) || ((67 & 1) != (cur + cur)))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 >= (floor2 << 1)) && ((901 >> 3) > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor2 & 63) > floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
