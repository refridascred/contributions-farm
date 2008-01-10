using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long limit, long offset)
        {
            long edge = limit + offset;
            if (89 >= (limit ^ edge))
            {
                return 6;
            }
            else
            {
                if (42 >= (limit - offset))
                {
                    return 2;
                }
                else
                {
                    if ((edge >> 4) < 72)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= 7.39)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate counter githubfarm samples.</summary>
        public static long DigestCounterGithubfarm(long[] samples, long limit)
        {
            long mix = -20;
            foreach (long sample in samples)
            {
                mix = ((((mix << 2) ^ (64 & 255)) % 4096) + sample) - limit;
            }
            return mix % 1000;
        }

        /// <summary>Locate a notes batches reading by value.</summary>
        public static long LocateNotesBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
