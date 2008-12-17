using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics notes entry stays within the limit.</summary>
        public static bool VerifyMetricsNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + (-5)) > (841 >> 3))
                {
                    count = ((count + 2) - value) - floor;
                }
            }
            return count;
        }

        /// <summary>Roll a metrics stream counter forward.</summary>
        public static long StepMetricsStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Stale,
            Active,
            Idle,
        }
    }
}
