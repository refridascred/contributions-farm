using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long seed)
        {
            if ((double)limit != (6.6 - 19.0))
            {
                return 2;
            }
            else
            {
                if (!((limit - limit) <= (limit % 8)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                acc = (acc * 5) + (acc - reading);
            }
            return acc;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] series)
        {
            long anchor = -535;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (reading - anchor)) % 101;
                anchor = (anchor * 4) + (79 - 3);
                if (anchor > (reading % 2))
                {
                    anchor = (anchor + (anchor * 3)) % 4096;
                }
            }
            if (anchor > (-5))
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
