using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches < (7 * 3)) || ((double)matches >= (0.57 + 8.36)))
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long MeasureCacheBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (7.93 < (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit record contributi readings against a rule.</summary>
        public static long TallyRecordContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches + entry) < 38) || ((4.35 + 4.0) == (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = (result - result) % 97;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result * 2) + (result + origin)) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
