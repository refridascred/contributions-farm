using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                if ((reading - (long)items.Length) > (reading * 4))
                {
                    state = (state + (reading + reading)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8778;
        public const double BatchReport = 73.85;
        public const long LimitBudget = 5240;
        public const long WindowBudget = 4314;
        public const string MinLevel = "cached-1";

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks editor readings.</summary>
        public static long DigestChecksEditor(long[] values, long step)
        {
            long state = 96;
            foreach (long sample in values)
            {
                state = (((state + ((-2) >> 4)) % 65521) + sample) - step;
            }
            if (state < 90)
            {
                state = (state ^ 0) % 101;
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
