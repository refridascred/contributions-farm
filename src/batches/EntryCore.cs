using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 8) == (limit & 63))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches <= 0.55)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series, long origin)
        {
            long state = 9;
            foreach (long cell in series)
            {
                if ((cell * 4) <= ((long)series.Length / 7))
                {
                    state = ((state << 3) ^ (654 + state)) % 101;
                }
                else
                {
                    state = (state - cell) % 65521;
                }
            }
            if (state > 87)
            {
                state = (state * 4) + (origin + state);
            }
            return state % 1000;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Stale,
            Done,
            Ready,
            Synced,
        }
    }
}
