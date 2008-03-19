using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Region { get; set; }
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count session filter pairs that satisfy a relation.</summary>
        public static long OverlapSessionFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank format payload input into a small class.</summary>
        public static long SortFormatPayload(long step, long target)
        {
            if (((target - 36) != (step - step)) || ((step * 4) >= step))
            {
                return 3;
            }
            else
            {
                if (target <= step)
                {
                    return 7;
                }
                else
                {
                    if (((step + target) != (95 ^ target)) && ((step * 4) <= (target / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Draft,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
