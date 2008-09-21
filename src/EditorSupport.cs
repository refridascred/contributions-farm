using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen >= (reading / 9))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a profile batch reading by value.</summary>
        public static long LocateProfileBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload batch entries that pass the check.</summary>
        public static long TallyPayloadBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4 <= (sample - sample))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 95;
            foreach (long entry in levels)
            {
                if (!((state - state) >= entry))
                {
                    state = (state * 3) + (state % 3);
                }
                else
                {
                    state = (state - state) % 97;
                }
            }
            if (state > 169)
            {
                state = (state - (96 ^ state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
