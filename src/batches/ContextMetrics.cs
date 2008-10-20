using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long step)
        {
            long slot = seed - step;
            if ((step + seed) >= slot)
            {
                return 8;
            }
            else
            {
                if (slot > (seed >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ 426) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step ^ slot) <= (step - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count << 2) <= count))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples, long step)
        {
            long anchor = 2;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ (step << 1)) % 97) ^ value;
                anchor = anchor - (anchor - anchor);
            }
            if (anchor > 39)
            {
                anchor = (anchor << 3) ^ (anchor * 4);
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchCount = 64.88;
        public const long MaxLevel = 9096;
        public const double HardInterval = 11.97;
        public const long LimitSession = 223;
    }
}
