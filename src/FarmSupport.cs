using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long acc = -49;
            foreach (long datum in levels)
            {
                acc = (acc << 2) ^ (datum + 62);
            }
            if (acc > 296)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading / 3) <= tally)
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
