using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 8035;
        public const string BaseBuffer = "latest";
        public const double MaxBuffer = 37.17;
        public const double MinDepth = 26.63;

        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool GuardFormatContextLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                anchor = anchor ^ item;
                anchor = anchor + (item / 5);
            }
            if (anchor > (-4))
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 7002;
        public const string MinChecks = "staging-1";
        public const double CacheLevel = 21.04;
        public const long WindowChecks = 6289;
        public const long BaseChecks = 7108;

        /// <summary>Measure how many already counter samples are out of range.</summary>
        public static long TallyAlreadyCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((6.3 / 2.0) <= (double)cell) && ((matches + matches) >= ((long)items.Length + cell))) && (matches >= (matches % 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
