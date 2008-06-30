using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit notes payload readings against a rule.</summary>
        public static long AuditNotesPayloadGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((cell + 22) >= cell))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long mix = 172;
            foreach (long cell in levels)
            {
                mix = mix ^ 182;
                if ((mix > (-2)) && ((cell % 3) != (cell & 15)))
                {
                    break;
                }
            }
            if (mix > 80)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((tally + tally) != (reading & 31)) && (((long)series.Length + 99) < 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Idle,
            Dropped,
        }
    }
}
