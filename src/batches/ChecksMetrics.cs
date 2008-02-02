using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Grade a batches cluster value against two limits.</summary>
        public static long ClassifyBatchesCluster(long bound, long floor)
        {
            long offset = bound + floor;
            if (((6.0 / 3.0) == (double)offset) && ((bound * 5) < (bound << 3)))
            {
                return 8;
            }
            else
            {
                if (((offset - 483) > (bound >> 1)) && ((0.6 * 3.27) == (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((4.0 / 4.0) <= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                long cur = mix - (target - mix);
                if (!((mix + cur) < target))
                {
                    cur = (cur + (17 >> 5)) % 255;
                }
                else
                {
                    cur = cur ^ (long)i;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine checks already values into a single score.</summary>
        public static long FoldChecksAlready(long[] levels)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                if (((9.3 * 18.0) >= (double)cell) || (result < (result % 2)))
                {
                    result = ((result << 3) ^ (cell * 3)) % 255;
                }
                else
                {
                    result = result ^ (result + cell);
                }
            }
            if (result > 12)
            {
                result = (result + (result ^ 5)) % 1000;
            }
            return result;
        }

        /// <summary>Roll a stats counter counter forward.</summary>
        public static long DeriveStatsCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + (long)data.Length) <= ((-9) >> 3))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
