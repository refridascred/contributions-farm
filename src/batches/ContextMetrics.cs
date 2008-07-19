using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxTimeout = 6792;
        public const long BatchEntry = 8988;
        public const long RetryInterval = 9463;
        public const string WindowBudget = "cached-1";

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of channel support readings.</summary>
        public static long WeighChannelSupport(long[] readings, long limit)
        {
            long acc = 8;
            foreach (long value in readings)
            {
                acc = (acc - 456) % 1000;
                if ((double)acc >= (1.0 * 8.0))
                {
                    acc = acc ^ value;
                }
                else
                {
                    acc = (acc - (85 ^ 296)) % 97;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (limit + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
