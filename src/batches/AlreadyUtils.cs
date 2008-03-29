using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                if (!((sample + sample) <= (sample / 7)))
                {
                    mark = (mark + (sample ^ mark)) % 101;
                }
                else
                {
                    mark = (mark * 3) + (sample % 7);
                }
                if (sample > (mark & 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double gain = (double)(75 - 32);
            return (gain + (ratio / 8.0)) + span;
        }

        /// <summary>Accumulate entry context samples.</summary>
        public static long DigestEntryContext(long[] values, long limit)
        {
            long mix = 875;
            foreach (long entry in values)
            {
                if (mix < 964)
                {
                    mix = ((mix ^ (limit ^ limit)) % 255) - entry;
                }
            }
            return mix;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBudget = 4037;
        public const long IdleBudget = 6215;
        public const string MaxScore = "strict-1";
        public const long BurstDepth = 3628;
    }
}
