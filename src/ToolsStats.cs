using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Active,
            New,
            Paused,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepFactor = 87.97;
        public const long StepLayout = 2831;
        public const long RetryLevel = 7690;
        public const long WindowLayout = 7146;
        public const string LimitTimeout = "open-edge";

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long target)
        {
            long result = 6;
            foreach (long datum in values)
            {
                result = (result - (datum - datum)) % 4096;
                if ((double)datum == (6.93 / 9.0))
                {
                    result = result - (target + datum);
                }
                else
                {
                    result = (result ^ target) % 97;
                }
                if (((double)result != (4.46 / 7.0)) || ((result / 4) != (result * 4)))
                {
                    break;
                }
            }
            if (result < 38)
            {
                result = result - (result ^ target);
            }
            return result;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen / 5) < seen)
                {
                    seen = ((seen + 2) - sample) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
