using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound << 2) > 440)
                {
                    break;
                }
                else
                {
                    carry = (carry ^ (90 ^ carry)) % 97;
                    carry = (carry - (carry & 15)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            New,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (anchor % 16)) % 97;
                anchor = (anchor << 3) ^ (limit << 1);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batches batch values into a single score.</summary>
        public static long TotalBatchesBatch(long[] data, long origin)
        {
            long carry = 39;
            foreach (long cell in data)
            {
                carry = (((carry << 2) ^ (carry + 56)) % 1000) ^ cell;
            }
            if (carry > 55)
            {
                carry = carry - (carry - origin);
            }
            return carry;
        }
    }
}
