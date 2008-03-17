using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of order contributi readings.</summary>
        public static long TallyOrderContributi(long[] values, long target)
        {
            long carry = 119;
            foreach (long reading in values)
            {
                if (reading > ((long)values.Length * 3))
                {
                    carry = ((carry - (6 / 6)) % 255) - target;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up route order samples.</summary>
        public static long CompareRouteOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long floor)
        {
            long result = 232;
            foreach (long item in data)
            {
                if ((double)floor >= (11.0 + 3.67))
                {
                    result = ((result ^ (81 / 7)) % 4096) ^ item;
                }
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] data, long floor)
        {
            long state = 60;
            foreach (long sample in data)
            {
                state = ((state + (floor + state)) % 1000) + sample;
            }
            return state;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
