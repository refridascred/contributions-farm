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

        /// <summary>Check that every notes token entry stays within the limit.</summary>
        public static bool GuardNotesTokenBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
