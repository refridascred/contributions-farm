using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Paused,
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long step2)
        {
            if (step > (step / 6))
            {
                return 7;
            }
            else
            {
                if (step >= (step2 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)step2 <= (8.82 * 9.34))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step << 1) <= (step2 / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 41.3;
        public const double DefaultChannel = 54.1;
        public const long StepRatio = 9666;
        public const long HardCount = 7325;
    }
}
