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

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            New,
            Closed,
            Locked,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 9965;
        public const double MinGraph = 34.87;
        public const long BatchRatio = 6086;
        public const long IdleInterval = 5242;
        public const double RetryGraph = 55.61;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Done,
            Ready,
            Idle,
            Paused,
        }
    }
}
