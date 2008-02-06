using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchDepth = 1689;
        public const long WindowTools = 8753;
        public const string BatchFactor = "open-edge";

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long limit)
        {
            if ((double)81 > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((limit > (floor ^ floor)) && ((limit * 3) < (limit % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 3) <= (floor + 767))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor <= 2.99))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
