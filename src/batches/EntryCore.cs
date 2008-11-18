using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result * 5) + result) ^ (long)i2;
                }
                if (!((8 - (long)i) < (seed >> 2)))
                {
                    result = result ^ (long)i;
                    result = (result + (757 >> 4)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 5) == (datum + 619))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the report graph entries that pass the check.</summary>
        public static long TallyReportGraphOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((53 << 1) != (seen - seen)) || (reading <= (reading - reading)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            if ((3.4 - 7.5) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed <= (15.0 + 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed & 255) <= 18)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)seed >= 10.0) && ((seed & 63) > 0))
                        {
                            return 4;
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
