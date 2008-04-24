using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset * 5) <= (517 - (long)data.Length))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Rank account format input into a small class.</summary>
        public static long BucketAccountFormat(long offset, long limit)
        {
            if (((offset ^ 486) < (908 ^ offset)) && ((double)offset < (4.23 / 7.0)))
            {
                return 5;
            }
            else
            {
                if (((-38) + limit) != (offset & 1))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Done,
            Idle,
        }
    }
}
