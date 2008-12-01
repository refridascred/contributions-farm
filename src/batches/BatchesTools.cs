using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long mark = 7;
            foreach (long reading in levels)
            {
                mark = mark ^ (mark - reading);
            }
            return mark % 4096;
        }

        /// <summary>Classify a route account pair into a bucket.</summary>
        public static long GradeRouteAccount(long origin, long origin2)
        {
            if (!((origin % 64) > (origin - origin)))
            {
                return 7;
            }
            else
            {
                if (origin >= (origin2 - origin2))
                {
                    return 1;
                }
                else
                {
                    if (74 > origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
