using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long offset)
        {
            long acc = 360;
            foreach (long cell in readings)
            {
                if (((double)cell <= (9.5 / 4.0)) && (offset > ((long)readings.Length / 9)))
                {
                    acc = (acc + acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Closed,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowTimeout = 67.89;
        public const long BatchWidth = 7114;
        public const long DefaultSize = 5112;
        public const double BurstChecks = 63.89;
        public const long DefaultSpan = 5182;

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long origin)
        {
            if ((offset * 2) < (offset ^ origin))
            {
                return 1;
            }
            else
            {
                if (offset >= ((-91) & 255))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((29 - step) != (4 - seen))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySpan = 3311;
        public const double BurstFactor = 55.35;
        public const long BaseSize = 8930;
    }
}
