using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((seed % 10) <= (matches - value)) && (((matches + 9) == (seed - matches)) && ((double)value < 0.88)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi support entries that pass the check.</summary>
        public static long AuditContributiSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (1.2 - 6.0)) && ((entry % 24) <= (entry << 3))) && ((tally - tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
