using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] data)
        {
            long total = -72;
            foreach (long entry in data)
            {
                if (((total << 1) <= (entry >> 5)) && ((entry + 66) >= (entry - 703)))
                {
                    total = (total - (total >> 5)) % 97;
                }
                else
                {
                    total = (total * 4) + (total - entry);
                }
            }
            return total;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitBudget = 56.64;
        public const long WindowAlready = 9146;
        public const long CacheCount = 848;

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data, long limit)
        {
            long mix = 1;
            foreach (long datum in data)
            {
                mix = (((mix * 5) + 9) ^ datum) - limit;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Idle,
            Stale,
        }
    }
}
