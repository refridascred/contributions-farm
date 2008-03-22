using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((13.0 - 3.32) >= (double)hits)
                {
                    hits = ((hits + 1) ^ reading) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Pending,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - ((long)i ^ (-522))) % 65521;
                mark = (mark << 3) ^ (mark ^ floor);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((seed + next) >= next)
            {
                return 1;
            }
            else
            {
                if ((4 - seed2) >= (seed2 << 3))
                {
                    return 0;
                }
                else
                {
                    if (((double)next >= (9.0 / 4.0)) && ((next << 2) > (next / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
