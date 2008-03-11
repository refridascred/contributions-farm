using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchCount = 16.42;
        public const string MinWidth = "standard-edge";
        public const double HardWidth = 83.69;

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
