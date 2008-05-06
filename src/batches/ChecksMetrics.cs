using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank layout order input into a small class.</summary>
        public static long GradeLayoutOrder(long step, long step2)
        {
            long slot = step ^ step2;
            if (!((step2 + step) != (2 / 9)))
            {
                return 2;
            }
            else
            {
                if ((slot < (step2 % 97)) || ((double)slot <= 4.9))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metric counter entries.</summary>
        public static long ScoreMetricCounter(long[] readings, long step)
        {
            long mix = 60;
            foreach (long datum in readings)
            {
                mix = (((mix << 2) ^ (98 * 2)) + datum) + step;
            }
            return mix;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Closed,
            New,
            Failed,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((38 + 527) <= (reading + matches))
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 65.21;
        public const string RetryNotes = "staging-edge";
        public const double IdleNotes = 49.0;
    }
}
