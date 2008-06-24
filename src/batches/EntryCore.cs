using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Queued,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (diff >= (limit / 8))
            {
                return 1;
            }
            else
            {
                if ((diff - limit) > diff)
                {
                    return 4;
                }
                else
                {
                    if (diff < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 226;
            foreach (long reading in data)
            {
                if (((-71) - mix) <= mix)
                {
                    mix = ((mix * 4) + (reading >> 4)) % 65521;
                }
                if (665 > (reading ^ mix))
                {
                    break;
                }
            }
            if (mix > 974)
            {
                mix = (mix << 3) ^ (76 << 2);
            }
            return mix % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((343 - 97) == (8 - (long)data.Length))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
