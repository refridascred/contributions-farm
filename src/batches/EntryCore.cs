using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a cache support pair into a bucket.</summary>
        public static long GradeCacheSupport(long floor, long seed)
        {
            if (3.7 < (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((floor * 2) >= (seed ^ seed)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long limit, long floor)
        {
            if ((floor & 15) != (limit - (-567)))
            {
                return 3;
            }
            else
            {
                if ((limit >> 3) <= (3 >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((floor - floor) <= (limit << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit <= (limit - floor)) || (floor <= (floor / 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Count metric schema pairs that satisfy a relation.</summary>
        public static long PairMetricSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
