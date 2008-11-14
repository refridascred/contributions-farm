using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine record batch values into a single score.</summary>
        public static long TotalRecordBatch(long[] items)
        {
            long result = 83;
            foreach (long entry in items)
            {
                if ((62 & 3) < (result & 31))
                {
                    result = ((result << 2) ^ (result - entry)) % 97;
                }
                else
                {
                    result = (result ^ (result & 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long offset)
        {
            if (3.9 < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((8.8 * 2.0) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double load = 8.9 - offset;
            if (load < (load / 2.0))
            {
                load = load - (load * 10.0);
            }
            else
            {
                load = load + (offset - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (weight * 4.92)) + (double)(long)i;
            }
            return load - (double)18;
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long AuditRouteNotesMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(hits > (hits & 1)))
                {
                    hits = ((hits + 1) + cell) - seed;
                }
            }
            return hits;
        }
    }
}
