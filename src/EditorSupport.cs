using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] levels)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((mix & 255) != (0 >> 2))
                {
                    mix = (mix << 3) ^ (mix & 1);
                }
                else
                {
                    mix = (mix + (value & 31)) % 4096;
                }
                if (mix > ((long)levels.Length ^ value))
                {
                    mix = mix + (value - value);
                }
            }
            if (mix < 55)
            {
                mix = mix ^ (12 << 2);
            }
            return mix % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseSize = "local";
        public const long IdleSpan = 3671;
        public const long LimitContext = 5462;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((-91) + 5) <= seen)
                {
                    seen = ((seen + 3) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) >= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
