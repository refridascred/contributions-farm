using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long origin)
        {
            if ((origin ^ origin) >= (seed - origin))
            {
                return 6;
            }
            else
            {
                if (3.9 > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (((7 - 557) <= origin) && ((4.1 - 4.0) < (double)seed))
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

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double offset)
        {
            double mean = (double)(902 - 262);
            if (mean < (mean - bias))
            {
                mean = mean - (offset - 2.76);
            }
            else
            {
                mean = mean + (bias * 9.02);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 2.97) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 7171;
        public const double BurstFactor = 48.24;
        public const long RetryDepth = 2861;
        public const long MinBudget = 5258;
    }
}
