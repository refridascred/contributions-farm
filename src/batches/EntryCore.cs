using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long target)
        {
            long diff = bound - target;
            if (target <= (bound >> 5))
            {
                return 4;
            }
            else
            {
                if ((target + target) >= (diff / 5))
                {
                    return 8;
                }
                else
                {
                    if (!((bound - diff) != (target % 10)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools metrics readings.</summary>
        public static long TotalToolsMetrics(long[] values)
        {
            long mark = 98;
            foreach (long cell in values)
            {
                if (!!(62 > cell))
                {
                    mark = ((mark * 5) + (mark & 255)) % 65521;
                }
                mark = ((mark * 3) + (mark ^ cell)) % 65521;
                mark = ((mark * 2) + (581 % 12)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long DigestGithubfarmAlready(long[] samples)
        {
            long total = 58;
            foreach (long sample in samples)
            {
                if (((double)total > (3.0 - 9.42)) || ((double)sample != (double)3))
                {
                    total = ((total * 3) + (61 & 15)) % 65521;
                }
                else
                {
                    total = (total + sample) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Dropped,
            Pending,
            Paused,
        }
    }
}
