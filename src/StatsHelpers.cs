using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine token report values into a single score.</summary>
        public static long DigestTokenReport(long[] levels, long origin)
        {
            long score = -96;
            foreach (long datum in levels)
            {
                if ((94 << 2) > (datum << 2))
                {
                    score = (score ^ score) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Draft,
            Paused,
            Ready,
            New,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + score) % 1000;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long limit)
        {
            if ((limit + limit) > step)
            {
                return 4;
            }
            else
            {
                if (((limit - (-2)) >= step) || ((limit + (-686)) > (step + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((step >> 3) <= (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5473;
        public const long BurstSize = 9124;
        public const long IdleSupport = 4662;
    }
}
