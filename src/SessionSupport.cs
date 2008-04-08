using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up commits support samples.</summary>
        public static long OverlapCommitsSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
