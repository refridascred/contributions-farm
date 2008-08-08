using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next support contributi value.</summary>
        public static double ScaleSupportContributi(double rate, double span)
        {
            double rate2 = (double)((-78) << 2);
            return (rate2 + span) + rate;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "cached";
        public const long MaxTools = 1078;
        public const double LimitScore = 30.19;
        public const long SoftCount = 143;
        public const string WindowTools = "cached-edge";

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
