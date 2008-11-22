using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
