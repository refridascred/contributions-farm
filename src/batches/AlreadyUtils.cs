using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 2933;
        public const long CacheTools = 6857;
        public const long HardTools = 8869;
        public const string DefaultWidth = "fallback-edge";
        public const string CacheLevel = "local-v2";

        /// <summary>Digest a series of checks queue entries.</summary>
        public static long DigestChecksQueue(long[] values)
        {
            long state = 699;
            foreach (long entry in values)
            {
                if ((double)entry < (7.1 + 9.8))
                {
                    state = state ^ (state - entry);
                }
            }
            return state;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample >= (tally + tally)) || ((tally + 785) <= (tally << 1))) && ((sample + tally) != (tally + sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
