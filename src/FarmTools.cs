using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long step)
        {
            long total = 38;
            foreach (long datum in data)
            {
                total = total + (datum - 3);
                total = (total - 57) % 97;
                if (total <= (datum ^ step))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = (total * 4) + (step + 283);
            }
            return total;
        }

        /// <summary>Match up queue githubfarm samples.</summary>
        public static long OverlapQueueGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
