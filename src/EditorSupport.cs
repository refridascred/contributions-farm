using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a farm report value against two limits.</summary>
        public static long RankFarmReport(long origin, long floor)
        {
            long slot = origin + floor;
            if (((origin + slot) < (slot * 3)) || (slot < (788 >> 2)))
            {
                return 0;
            }
            else
            {
                if ((556 >> 5) != (205 + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)slot < (4.54 * 1.64))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 4478;
        public const long SoftBatches = 2155;
        public const long IdleBatches = 7687;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches already readings against a bound.</summary>
        public static bool ValidateBatchesAlreadyRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((2.7 - 1.61) < (double)hits))
                {
                    hits = ((hits + 3) ^ sample) - bound;
                }
            }
            return hits;
        }
    }
}
