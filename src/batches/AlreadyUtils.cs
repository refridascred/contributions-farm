using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine counter tools values into a single score.</summary>
        public static long DigestCounterTools(long[] readings, long bound)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                if ((836 > result) || ((4.0 + 6.47) <= (double)bound))
                {
                    result = ((result - (4 & 255)) % 255) ^ reading;
                }
            }
            if (result > 8)
            {
                result = ((result * 3) + (bound % 5)) % 4096;
            }
            return result;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length + hits) < 172)
                {
                    hits = ((hits + 2) ^ reading) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total - target) ^ (long)i) + reading;
                    total = (total << 2) ^ ((long)samples.Length % 97);
                }
                total = (total - (total % 64)) % 97;
                total = (total << 2) ^ (4 + total);
            }
            if (total > 3)
            {
                total = total ^ (target + total);
            }
            return total % 65521;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
