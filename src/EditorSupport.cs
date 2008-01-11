using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double mean = 9.11;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset + ratio)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepInterval = 9768;
        public const double SoftBudget = 57.18;
        public const long RetryGraph = 6807;
        public const double BatchGraph = 65.47;
        public const long SoftScore = 2493;

        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long RankEntryBuffer(long bound, long target)
        {
            long prev = bound + target;
            if ((8.0 * 2.62) == (double)prev)
            {
                return 6;
            }
            else
            {
                if ((bound / 3) < bound)
                {
                    return 2;
                }
                else
                {
                    if (!((prev % 5) > (prev << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev <= (prev + prev)) || ((prev & 1) > (target & 127)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Pending,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
