using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double HardInterval = 84.18;
        public const long LimitSize = 5470;
        public const long LimitFarm = 6130;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((2.0 / 9.0) > (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((3.15 - 4.86) <= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine support tools values into a single score.</summary>
        public static long FoldSupportTools(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (1 + 9)) ^ entry;
                if ((double)state > (8.43 + 5.0))
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Idle,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if (8.4 > (double)mix)
                {
                    mix = ((mix * 5) + (mix + mix)) % 4096;
                    mix = (mix << 3) ^ (154 % 12);
                }
                if (((-1) * 2) >= (cell << 3))
                {
                    mix = mix - (mix << 1);
                }
                else
                {
                    mix = (mix - (cell % 16)) % 65521;
                }
            }
            return mix;
        }
    }
}
