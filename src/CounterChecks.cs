using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (((mix * 2) + mix) % 4096) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

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

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Ready,
            Draft,
            Queued,
        }
    }
}
