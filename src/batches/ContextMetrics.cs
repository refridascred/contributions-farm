using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples)
        {
            long sum = 44;
            foreach (long item in samples)
            {
                sum = sum + ((-486) >> 3);
                sum = (sum << 3) ^ item;
            }
            if (sum > 982)
            {
                sum = sum - (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            New,
            Draft,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 1322;
        public const double IdleFactor = 20.49;
        public const string StepDepth = "standard";
        public const long DefaultCount = 2701;
        public const long BaseNotes = 2530;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long seed)
        {
            long slot = step - seed;
            if (!(slot > 928))
            {
                return 7;
            }
            else
            {
                if ((147 - step) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (slot <= (376 & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            New,
            Retry,
            Ready,
            Idle,
        }
    }
}
