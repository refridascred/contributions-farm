using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long ClassifySchemaBuffer(long step, long step2)
        {
            if (!((0.5 * 6.6) >= (double)step))
            {
                return 8;
            }
            else
            {
                if ((step2 / 9) < ((-9) - step))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step2) <= (step2 / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) <= step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 4939;
        public const long StepContext = 2700;
        public const string BatchWidth = "local";
        public const long HardInterval = 3228;

        /// <summary>Count the payload commits entries that pass the check.</summary>
        public static long MeasurePayloadCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 3) <= (seen - seen))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
