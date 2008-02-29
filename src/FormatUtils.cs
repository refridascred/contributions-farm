using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every profile already entry stays within the limit.</summary>
        public static bool ValidateProfileAlreadyLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a counter stream pair into a bucket.</summary>
        public static long SortCounterStream(long target, long bound)
        {
            long diff = target - bound;
            if ((diff / 6) <= diff)
            {
                return 2;
            }
            else
            {
                if (target < (diff + diff))
                {
                    return 3;
                }
                else
                {
                    if ((bound % 100) == (target >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
