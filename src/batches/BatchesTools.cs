using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long origin)
        {
            long acc = 76;
            foreach (long reading in samples)
            {
                if (((3.71 + 2.9) > (double)origin) || ((acc % 16) >= (acc + origin)))
                {
                    acc = (acc ^ (origin - origin)) ^ reading;
                }
            }
            return acc % 97;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
