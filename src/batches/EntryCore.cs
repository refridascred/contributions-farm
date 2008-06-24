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

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
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
