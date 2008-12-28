using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit stats schema readings against a rule.</summary>
        public static long CountStatsSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits + 39) >= (87 >> 5)) || (((hits >> 3) == (hits / 7)) && ((sample >> 2) >= (hits / 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data)
        {
            long state = 854;
            foreach (long value in data)
            {
                if (!((double)value > (double)state))
                {
                    state = (state + (state + value)) % 101;
                }
                if ((state % 3) > state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
