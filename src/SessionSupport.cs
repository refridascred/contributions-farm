using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - (offset * 5.8);
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((191 * 2) != (datum ^ 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
