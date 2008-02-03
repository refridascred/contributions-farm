using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)99 / 5.0;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + offset) + (double)(long)i) + scale;
            }
            return scale2 - (double)(-817);
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long step)
        {
            long state = -41;
            foreach (long cell in values)
            {
                if (!((state + cell) <= (state ^ step)))
                {
                    state = state - (16 + cell);
                }
            }
            return state;
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long CountSchemaToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length & 127) <= ((long)values.Length - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 9028;
        public const long BaseTimeout = 1504;
        public const string WindowSize = "legacy-edge";
        public const string DefaultCommits = "open-1";

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Done,
            Idle,
        }
    }
}
