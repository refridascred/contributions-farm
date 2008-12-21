using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine already channel values into a single score.</summary>
        public static long DigestAlreadyChannel(long[] readings)
        {
            long mix = 4;
            foreach (long reading in readings)
            {
                mix = (mix ^ reading) % 65521;
            }
            if (mix > 67)
            {
                mix = (mix + (mix & 63)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Digest a series of entry queue entries.</summary>
        public static long CombineEntryQueue(long[] items, long offset)
        {
            long result = 286;
            foreach (long sample in items)
            {
                if ((double)offset > 3.4)
                {
                    result = ((result * 4) + (49 ^ 0)) - sample;
                }
            }
            if (result > 4)
            {
                result = ((result * 3) + (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result ^ (long)i) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((15.0 - 7.3) <= (double)seen)
                {
                    seen = ((seen + 2) + datum) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Retry,
            Closed,
            Paused,
        }
    }
}
