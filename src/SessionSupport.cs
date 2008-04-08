using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every batches commits entry stays within the limit.</summary>
        public static bool GuardBatchesCommitsLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long StepSchemaQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (offset % 97)) % 65521;
                if ((-8) >= (acc << 2))
                {
                    acc = (acc + (long)i) % 255;
                }
                if (!((double)acc <= (9.0 - 2.0)))
                {
                    acc = (acc ^ (offset << 1)) % 4096;
                    acc = (acc + offset) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading > (hits + (-9))) && !((5.0 + 6.9) == (double)hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
