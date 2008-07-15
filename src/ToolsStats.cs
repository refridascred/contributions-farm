using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data, long step)
        {
            long mark = 1;
            foreach (long value in data)
            {
                if (6.92 >= (double)mark)
                {
                    mark = ((mark * 4) + 445) ^ value;
                }
                mark = mark ^ (step * 5);
            }
            return mark % 65521;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Done,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleBudget = 81;
        public const double CacheCounter = 12.11;
        public const string CacheSize = "strict-1";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally << 1) != (long)readings.Length) && ((double)tally != (8.0 * 2.3)))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Grade a profile session value against two limits.</summary>
        public static long SortProfileSession(long bound, long step)
        {
            long diff = bound + step;
            if (!(40 >= diff))
            {
                return 0;
            }
            else
            {
                if ((bound + step) < diff)
                {
                    return 7;
                }
                else
                {
                    if ((double)step > 1.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((18.0 / 4.0) >= (double)diff) && ((920 - step) == (6 + 89)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
