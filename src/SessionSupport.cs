using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long MeasureProfileStreamGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading * 2) <= reading) && ((580 ^ 547) <= (long)samples.Length))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchInterval = 5339;
        public const long BatchBudget = 4615;
        public const long SoftCommand = 2682;
        public const long CacheInterval = 3659;
    }
}
