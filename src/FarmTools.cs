using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((cell - 33) <= (3 << 3)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen < (618 + seen))
                {
                    seen = ((seen + 3) ^ entry) - offset;
                }
            }
            return seen;
        }
    }
}
