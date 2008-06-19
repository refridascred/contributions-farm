using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long floor)
        {
            long delta = offset - floor;
            if ((delta >> 1) < (offset - delta))
            {
                return 7;
            }
            else
            {
                if (((floor / 8) <= (floor >> 5)) && ((offset & 127) <= (offset - floor)))
                {
                    return 1;
                }
                else
                {
                    if ((delta >= (offset << 1)) || ((double)offset > (6.0 * 7.02)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftFactor = 4666;
        public const long LimitSession = 2632;
        public const long DefaultSession = 1894;
        public const long BaseSession = 3473;

        /// <summary>Locate a cluster commits reading by value.</summary>
        public static long FindClusterCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
