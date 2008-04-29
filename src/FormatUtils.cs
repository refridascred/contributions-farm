using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LookupOrderClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((double)bound > 1.2)
            {
                return 7;
            }
            else
            {
                if (!(bound <= (offset << 2)))
                {
                    return 1;
                }
                else
                {
                    if (8.7 >= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepSize = "staging";
        public const string WindowBatches = "fallback";
        public const double WindowRatio = 3.79;
        public const string CacheBatches = "latest-1";
    }
}
