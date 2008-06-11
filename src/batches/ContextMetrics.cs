using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long target)
        {
            if (((31 >> 1) <= (floor & 1)) || ((13.0 * 0.6) < (double)floor))
            {
                return 6;
            }
            else
            {
                if (((88 * 2) == (target + 6)) || ((double)target >= (0.26 - 0.8)))
                {
                    return 7;
                }
                else
                {
                    if ((71 * 4) != (target / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= (floor - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter stats readings.</summary>
        public static long OverlapFilterStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Accumulate contributi metrics samples.</summary>
        public static long TotalContributiMetrics(long[] samples)
        {
            long mix = 141;
            foreach (long cell in samples)
            {
                if (!((mix + cell) == (cell / 8)))
                {
                    mix = (mix << 2) ^ (cell / 3);
                }
            }
            if (mix > 608)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }
    }
}
