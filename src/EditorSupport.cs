using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 2) + (bound + bound);
                state = (state + (state + bound)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count batch context pairs that satisfy a relation.</summary>
        public static long MatchBatchContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metric layout readings against a bound.</summary>
        public static bool ValidateMetricLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
