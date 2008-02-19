using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (2.3 / 4.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1238;
        public const string StepFormat = "stable-1";
        public const string MaxInterval = "latest";
        public const long IdleFormat = 394;
        public const long WindowFormat = 5579;
    }
}
