using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long offset)
        {
            long lane = step - offset;
            if ((lane - offset) <= (658 - step))
            {
                return 2;
            }
            else
            {
                if (!((0 + offset) > 638))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 43.32;
        public const long WindowSize = 4101;
        public const string LimitSize = "alpha-1";
        public const long StepFormat = 2396;
        public const long BatchBudget = 5286;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            New,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
