using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 1630;
        public const long BaseScore = 3181;
        public const double StepScore = 70.33;
        public const double BaseGraph = 56.58;
        public const long CacheGraph = 3728;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Synced,
            Done,
            Closed,
        }

        /// <summary>Grade a token payload value against two limits.</summary>
        public static long GradeTokenPayload(long offset, long step)
        {
            long step2 = offset ^ step;
            if ((89 > (offset - step2)) || (step >= (offset * 5)))
            {
                return 7;
            }
            else
            {
                if ((58 << 1) <= (75 + step2))
                {
                    return 8;
                }
                else
                {
                    if ((961 & 15) > (offset / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
