using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell ^ seen) < (367 >> 5)) || ((cell ^ seen) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally > (tally / 3))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Closed,
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long acc = 377;
            foreach (long reading in values)
            {
                if ((reading << 1) >= acc)
                {
                    acc = (acc << 2) ^ (reading ^ reading);
                }
            }
            if (acc < 9)
            {
                acc = ((acc * 3) + acc) % 1000;
            }
            return acc;
        }
    }
}
