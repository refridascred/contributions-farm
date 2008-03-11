using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = total + step;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long MeasureToolsProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell % 97) != (41 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
