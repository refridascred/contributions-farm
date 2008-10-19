using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstInterval = 1557;
        public const long MaxStream = 3460;
        public const long StepSize = 4924;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long step, long offset)
        {
            if ((9.17 * 0.48) > (double)step)
            {
                return 6;
            }
            else
            {
                if ((4.0 * 0.14) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset + step) <= (step + 84))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 3) >= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark ^ (cell + mark)) % 101;
                    mark = (mark + ((long)i << 3)) % 65521;
                }
                mark = ((mark << 3) ^ cell) % 255;
                mark = (mark ^ (cell % 60)) % 1000;
            }
            return mark;
        }
    }
}
