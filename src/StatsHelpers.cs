using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Flag { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
                mix = mix + (25 + mix);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
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
