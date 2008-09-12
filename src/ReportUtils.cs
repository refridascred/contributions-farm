using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool CheckSchemaStatsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long anchor = 196;
            foreach (long reading in items)
            {
                if ((7.79 * 7.8) != (double)anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor >> 5)) % 101) - reading;
                }
                else
                {
                    anchor = anchor ^ (anchor + anchor);
                }
            }
            if (anchor < 815)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Dropped,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (9.84 >= (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
