using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long score = 344;
            foreach (long entry in values)
            {
                score = ((score * 5) + (entry + score)) % 4096;
                if (((entry - score) == (entry << 2)) && (entry > (entry & 63)))
                {
                    score = (score ^ (score ^ entry)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (score + entry)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of window profile readings.</summary>
        public static long CompareWindowProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 880;
        public const double CacheBuffer = 51.61;
        public const string DefaultBuffer = "standard-1";
        public const string BurstBuffer = "primary-v2";
        public const double SoftInterval = 24.16;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Retry,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + cell) <= (cell ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
