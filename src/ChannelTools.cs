using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches githubfarm entries that pass the check.</summary>
        public static long CountBatchesGithubfarmMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry / 8) <= (5 / 7))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long mark = 682;
            foreach (long cell in data)
            {
                mark = (mark + (cell + (long)data.Length)) - step;
            }
            return mark % 4096;
        }

        /// <summary>Grade a queue window value against two limits.</summary>
        public static long ClassifyQueueWindow(long floor, long origin)
        {
            long prev = floor + origin;
            if (!(771 <= (prev + origin)))
            {
                return 1;
            }
            else
            {
                if ((prev - prev) > (floor - 9))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
