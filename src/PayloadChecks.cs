using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Locked,
            New,
            Pending,
            Closed,
        }

        /// <summary>Check that every tools editor entry stays within the limit.</summary>
        public static bool ValidateToolsEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a buffer format value against two limits.</summary>
        public static long SortBufferFormat(long bound, long floor)
        {
            long prev = bound ^ floor;
            if (bound <= (bound + prev))
            {
                return 4;
            }
            else
            {
                if ((prev >> 4) >= prev)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 8622;
        public const long RetryTools = 584;
        public const string SoftTools = "fallback-edge";
        public const long MinRatio = 5372;
        public const long IdleTools = 1233;
    }
}
