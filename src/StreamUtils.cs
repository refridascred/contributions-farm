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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count / 8) == (3 >> 3))
                {
                    count = ((count + 2) + datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Idle,
            Dropped,
            Failed,
        }

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
