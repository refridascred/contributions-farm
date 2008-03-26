using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long offset, long target)
        {
            if (((-53) * 3) > (682 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset + 1) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Pending,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count > sample) && (sample > (sample / 8))) || ((sample > count) || ((double)sample > (8.5 + 2.0))))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples, long seed)
        {
            long mark = 423;
            foreach (long cell in samples)
            {
                if ((15.0 * 12.0) >= 5.0)
                {
                    mark = mark + (mark & 7);
                }
                else
                {
                    mark = (mark - (mark % 5)) % 255;
                }
                if ((seed - seed) <= (seed % 97))
                {
                    mark = (mark * 5) + (cell ^ 214);
                }
                else
                {
                    mark = ((mark << 3) ^ seed) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
