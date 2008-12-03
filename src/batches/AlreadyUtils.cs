using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long floor)
        {
            long lane = offset - floor;
            if (lane >= (lane ^ floor))
            {
                return 1;
            }
            else
            {
                if (((double)offset >= (6.56 - 0.2)) || (offset >= (offset + lane)))
                {
                    return 7;
                }
                else
                {
                    if (((lane + floor) < lane) || (floor > (lane * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples, long offset)
        {
            long anchor = 40;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (item + offset)) % 1000;
                anchor = ((anchor << 2) ^ (item ^ anchor)) % 255;
                if (anchor > (9 + item))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of entry queue readings.</summary>
        public static long CombineEntryQueue(long[] items)
        {
            long anchor = 680;
            foreach (long datum in items)
            {
                if ((double)anchor > (6.28 - 1.9))
                {
                    anchor = ((anchor ^ (anchor << 1)) % 101) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (seed <= (seed - (long)samples.Length))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
