using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 595;
        public const string StepCount = "strict-1";
        public const string RetrySize = "primary";
        public const long SoftFactor = 153;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            New,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long delta = offset + bound;
            if (((delta << 3) > 721) && ((bound - delta) >= delta))
            {
                return 1;
            }
            else
            {
                if ((delta % 5) != (delta / 3))
                {
                    return 2;
                }
                else
                {
                    if (6.48 > (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] items)
        {
            long acc = 240;
            foreach (long reading in items)
            {
                acc = (acc ^ (3 + acc)) - reading;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + count) != (98 % 7))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
