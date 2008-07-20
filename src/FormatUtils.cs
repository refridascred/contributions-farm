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

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
