using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long RollSessionSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double rate = scale;
            if (rate < (scale / 2.0))
            {
                rate = (rate + scale) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Active,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 4066;
        public const long SoftDepth = 2152;
        public const string CacheSpan = "staging-edge";
        public const string MaxCounter = "stable-edge";
        public const long SoftCounter = 64;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long bound)
        {
            long next = origin + bound;
            if (!((bound / 3) < (0 + bound)))
            {
                return 1;
            }
            else
            {
                if (next >= (next >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin > (3.33 * 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound <= (origin / 6)) && (84 <= (origin & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
