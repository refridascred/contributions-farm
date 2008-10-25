using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long ScoreGithubfarmCounter(long[] levels)
        {
            long result = -414;
            foreach (long cell in levels)
            {
                result = (result + cell) % 4096;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
