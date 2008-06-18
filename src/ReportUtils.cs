using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long score = 5;
            foreach (long reading in readings)
            {
                if (((double)reading > (double)431) || ((reading ^ 96) >= (score + score)))
                {
                    score = score - (reading ^ (-728));
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 2983;
        public const long BatchBudget = 2421;
        public const long BurstTools = 7966;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a context buffer value against two limits.</summary>
        public static long ClassifyContextBuffer(long limit, long floor)
        {
            long gap = limit ^ floor;
            if (floor < (limit + 955))
            {
                return 0;
            }
            else
            {
                if ((limit - 968) == (gap << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (14.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit != (2.9 - 6.9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
