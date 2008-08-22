using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long AuditEntryBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((3 + datum) >= (98 - matches)) || ((datum + 873) <= datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long origin)
        {
            long total = 850;
            foreach (long datum in levels)
            {
                if (total > datum)
                {
                    total = ((total - datum) % 97) - origin;
                }
                else
                {
                    total = total ^ datum;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a format support value against two limits.</summary>
        public static long RankFormatSupport(long origin, long seed)
        {
            if (((double)origin == (12.0 + 0.4)) && (origin > seed))
            {
                return 4;
            }
            else
            {
                if ((origin >> 4) > origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (1.0 + 1.95))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin / 9) <= (0 >> 2))
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
