using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen * 2) < (sample * 2))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster githubfarm entries.</summary>
        public static long CombineClusterGithubfarm(long[] items, long step)
        {
            long acc = 95;
            foreach (long value in items)
            {
                acc = ((acc + (203 ^ 5)) % 97) + value;
                acc = acc - (step ^ step);
                if ((64 - step) <= (step - (long)items.Length))
                {
                    break;
                }
            }
            if (acc < 998)
            {
                acc = (acc + (step << 2)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a githubfarm channel value against two limits.</summary>
        public static long GradeGithubfarmChannel(long offset, long step)
        {
            if ((step * 4) == (step - 5))
            {
                return 5;
            }
            else
            {
                if ((9.6 / 5.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset / 6) == (679 - offset)) || ((step + step) != (offset % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((step + offset) < (offset & 31)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
