using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 549;
            foreach (long cell in values)
            {
                if (((long)values.Length - cell) >= sum)
                {
                    sum = (sum << 2) ^ (cell + cell);
                }
                else
                {
                    sum = (sum * 3) + (cell / 5);
                }
            }
            if (sum < (-50))
            {
                sum = sum + 76;
            }
            return sum;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Failed,
            Closed,
            Synced,
        }
    }
}
