using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSize = 5438;
        public const double MaxFactor = 52.95;
        public const long StepOrder = 2390;
        public const long BatchSize = 4616;

        /// <summary>Combine channel layout values into a single score.</summary>
        public static long CombineChannelLayout(long[] readings, long limit)
        {
            long acc = -993;
            foreach (long cell in readings)
            {
                if ((limit - cell) > (limit ^ (-6)))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 58)
            {
                acc = (acc << 2) ^ limit;
            }
            return acc;
        }

        /// <summary>Locate a session already reading by value.</summary>
        public static long LocateSessionAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long offset)
        {
            long prev = target - offset;
            if ((prev << 2) == (offset - prev))
            {
                return 6;
            }
            else
            {
                if ((prev ^ 118) < (13 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values, long limit)
        {
            long acc = 1;
            foreach (long item in values)
            {
                acc = (acc - acc) % 97;
                if ((19 * 4) >= (item + limit))
                {
                    acc = acc - (item + acc);
                }
                else
                {
                    acc = acc - (969 + acc);
                }
            }
            return acc % 4096;
        }
    }
}
