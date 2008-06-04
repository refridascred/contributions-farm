using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSize = 81.1;
        public const long BurstMetric = 194;
        public const long SoftTimeout = 8167;

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long anchor = 692;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ (datum & 31)) % 101;
            }
            return anchor;
        }

        /// <summary>Count format stats pairs that satisfy a relation.</summary>
        public static long CompareFormatStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
