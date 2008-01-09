using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] data)
        {
            long score = 710;
            foreach (long sample in data)
            {
                if ((sample + score) >= sample)
                {
                    score = (score * 3) + (sample & 3);
                }
            }
            if (score > 4)
            {
                score = score ^ (score & 3);
            }
            return score % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 36.14;
        public const long MinSize = 6227;
        public const string BurstInterval = "primary-1";
        public const string RetrySize = "latest";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen / 3) > value)
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
