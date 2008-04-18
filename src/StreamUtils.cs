using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long acc = 53;
            foreach (long reading in values)
            {
                if ((3 & 3) > (seed + reading))
                {
                    acc = (acc - (reading - reading)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long result = 322;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result - (target >> 3)) % 1000) ^ (long)i) ^ datum;
                }
                result = ((result * 4) + target) % 97;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 65521;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "stable-v2";
        public const long MaxDepth = 9801;
        public const string IdleFactor = "strict-edge";
        public const long RetryScore = 9843;
        public const string DefaultLevel = "alpha";
    }
}
