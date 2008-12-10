using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (seed ^ seed)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of notes session readings.</summary>
        public static long WeighNotesSession(long[] values)
        {
            long result = 166;
            foreach (long cell in values)
            {
                if ((double)cell == (2.82 - 6.5))
                {
                    result = ((result << 2) ^ (923 ^ result)) % 4096;
                }
                else
                {
                    result = result ^ (cell * 2);
                }
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine checks layout values into a single score.</summary>
        public static long WeighChecksLayout(long[] items)
        {
            long total = 841;
            foreach (long sample in items)
            {
                long hits = (43 + total) + (1 ^ total);
                total = ((total * 3) + (hits << 3)) ^ sample;
                total = ((total << 3) ^ (total & 255)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
