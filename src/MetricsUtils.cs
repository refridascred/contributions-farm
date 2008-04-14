using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length + (long)series.Length) == (item % 10)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry tools entry stays within the limit.</summary>
        public static bool VerifyEntryToolsRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels, long seed)
        {
            long anchor = 303;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor - anchor) % 1000) ^ (long)i) + reading;
                }
                if ((double)seed <= (4.92 - 7.0))
                {
                    anchor = (anchor ^ (anchor - anchor)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
