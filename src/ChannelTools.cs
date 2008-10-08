using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long TallyLayoutEntryMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((96 << 1) < (value & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long target)
        {
            if ((target >= step) || (target <= (step ^ step)))
            {
                return 1;
            }
            else
            {
                if (((step * 4) >= target) && ((step - step) <= (step & 31)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((-98) <= hits)
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
