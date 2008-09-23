using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a session cluster pair into a bucket.</summary>
        public static long SortSessionCluster(long offset, long origin)
        {
            if (!((94 % 100) <= (offset % 3)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (8.91 + 6.7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of cluster graph entries.</summary>
        public static long FoldClusterGraph(long[] levels, long step)
        {
            long mix = 96;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 5) + 2) % 97) - (long)i;
                }
                mix = ((mix << 2) ^ (step % 2)) % 101;
                mix = ((mix * 4) + (25 + entry)) % 97;
                if (((1.2 - 2.0) <= (double)step) || ((entry >> 5) >= (mix - 6)))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
