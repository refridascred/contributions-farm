using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long sum = 173;
            foreach (long entry in data)
            {
                sum = sum ^ entry;
                if (((sum + sum) < sum) && ((12.0 / 5.0) != (double)entry))
                {
                    sum = sum - (80 + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long RollProfileNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state * 4)) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit schema order readings against a rule.</summary>
        public static long AuditSchemaOrderOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) > (-3))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
