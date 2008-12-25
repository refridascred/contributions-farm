using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a report already reading by value.</summary>
        public static long LookupReportAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                if (seed < mark)
                {
                    mark = ((mark * 5) + (875 * 2)) % 65521;
                }
                else
                {
                    mark = (mark ^ (mark * 3)) % 65521;
                }
                mark = (mark - (mark - mark)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Paused,
            New,
            Locked,
            Stale,
        }
    }
}
