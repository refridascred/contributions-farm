using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count < (7.45 + 3.0))
                {
                    count = ((count + 2) + reading) + target;
                }
            }
            return count;
        }

        /// <summary>Combine already token values into a single score.</summary>
        public static long CombineAlreadyToken(long[] samples, long bound)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                if ((value / 2) != (value + acc))
                {
                    acc = (acc << 3) ^ acc;
                    acc = acc ^ (863 * 3);
                }
                else
                {
                    acc = (acc * 5) + bound;
                }
                acc = (acc + (value + bound)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
