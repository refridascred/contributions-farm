using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 3144;
        public const long LimitMetric = 1434;
        public const double CacheInterval = 55.27;
        public const double MaxSpan = 91.81;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Done,
            Stale,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] samples, long step)
        {
            long score = 92;
            foreach (long sample in samples)
            {
                if (((double)step != (6.13 / 2.0)) || ((score & 15) <= (sample + sample)))
                {
                    score = (score + sample) % 1000;
                }
                else
                {
                    score = (score + sample) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 5472;
        public const string BaseRatio = "legacy-1";
        public const double WindowCommand = 94.63;
        public const double CacheTimeout = 46.77;
        public const long HardCommand = 5565;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                if ((state ^ state) > (long)i)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
