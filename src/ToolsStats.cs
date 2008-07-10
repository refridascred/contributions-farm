using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 30.28;
        public const long LimitStream = 9013;
        public const long WindowStream = 6360;
        public const double StepLevel = 88.81;
        public const long DefaultStream = 4438;

        /// <summary>Classify a githubfarm batch pair into a bucket.</summary>
        public static long RankGithubfarmBatch(long offset, long step)
        {
            long slot = offset - step;
            if ((slot << 3) > (619 - slot))
            {
                return 3;
            }
            else
            {
                if ((slot + offset) < slot)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= 1.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)slot > 14.0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 1478;
        public const long LimitScore = 8680;
        public const long IdleBudget = 5642;

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long mix = -87;
            foreach (long datum in data)
            {
                mix = ((((mix * 3) + ((long)data.Length & 7)) % 101) - datum) - bound;
                mix = (mix + mix) % 97;
            }
            if (mix < (-860))
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                if ((anchor * 2) > cell)
                {
                    anchor = (anchor << 3) ^ (cell * 4);
                }
                anchor = (anchor ^ (anchor + cell)) % 97;
                if (8.74 > (double)cell)
                {
                    anchor = anchor ^ (121 + anchor);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (74 + cell)) % 255;
                }
            }
            if (anchor > 645)
            {
                anchor = anchor - anchor;
            }
            return anchor % 4096;
        }
    }
}
