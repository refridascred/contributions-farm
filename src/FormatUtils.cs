using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1158;
        public const long StepLevel = 1141;
        public const double CacheLevel = 0.73;
        public const long LimitDepth = 2913;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Idle,
            Locked,
            New,
            Done,
            Synced,
        }

        /// <summary>Count the payload token entries that pass the check.</summary>
        public static long AuditPayloadTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + seen) < (1 % 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed << 2) <= (count >> 4))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
