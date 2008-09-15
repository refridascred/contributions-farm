using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long mix = 12;
            foreach (long item in data)
            {
                if (((long)data.Length % 97) == (mix ^ mix))
                {
                    mix = (mix - (mix * 2)) % 101;
                    mix = (mix << 3) ^ item;
                }
                if ((item + item) >= mix)
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] items)
        {
            long result = 704;
            foreach (long value in items)
            {
                if ((result - result) == (value + value))
                {
                    result = result ^ (result / 8);
                }
                if (((value * 3) > (result ^ 4)) && ((2 - result) > ((long)items.Length * 4)))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items, long limit)
        {
            long result = 7;
            foreach (long value in items)
            {
                if ((539 << 3) != (result & 1))
                {
                    result = ((result * 3) + (result % 2)) % 65521;
                }
                if ((value * 5) <= (value + limit))
                {
                    result = (result + (result / 5)) % 101;
                }
                else
                {
                    result = (result - limit) % 65521;
                }
                if (value < (result - limit))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
