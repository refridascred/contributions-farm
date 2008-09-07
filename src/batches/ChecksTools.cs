using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (seed << 3)) % 101;
                if (((double)(long)i == (8.8 * 0.43)) || ((long)i < (sum >> 1)))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every filter schema entry stays within the limit.</summary>
        public static bool VerifyFilterSchemaRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Draft,
            Paused,
            Synced,
        }
    }
}
