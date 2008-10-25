using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading < (6.9 + 6.37))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values, long bound)
        {
            long mark = -80;
            foreach (long sample in values)
            {
                mark = (mark ^ (98 ^ sample)) - bound;
            }
            return mark;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long floor)
        {
            if ((origin < (floor * 5)) && ((double)origin > (9.1 + 2.3)))
            {
                return 4;
            }
            else
            {
                if ((8 + floor) < 1)
                {
                    return 6;
                }
                else
                {
                    if ((origin % 10) > (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (23 < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
