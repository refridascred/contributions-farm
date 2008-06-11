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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if ((double)limit2 <= (1.0 + 12.0))
            {
                return 1;
            }
            else
            {
                if (limit > prev)
                {
                    return 2;
                }
                else
                {
                    if ((prev * 2) >= (limit2 - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
