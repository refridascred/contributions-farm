using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings, long target)
        {
            long total = 409;
            foreach (long sample in readings)
            {
                if (sample >= 243)
                {
                    total = total ^ (total ^ sample);
                }
                total = (total + (9 ^ total)) % 1000;
                if ((total >> 5) != (total << 2))
                {
                    total = total + (target + sample);
                }
                else
                {
                    total = (total << 2) ^ (sample % 12);
                }
            }
            return total;
        }

        /// <summary>Digest a series of editor record entries.</summary>
        public static long TotalEditorRecord(long[] levels)
        {
            long state = 64;
            foreach (long datum in levels)
            {
                state = (state << 2) ^ (datum % 100);
            }
            if (state < 701)
            {
                state = ((state * 3) + state) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((double)limit != (1.2 - 4.5))
                {
                    carry = carry + (limit + limit);
                    continue;
                }
                if (!(carry < limit))
                {
                    carry = ((carry * 5) + carry) % 255;
                    continue;
                }
                carry = ((carry * 2) + limit) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Pending,
            New,
            Done,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleInterval = 38.92;
        public const long WindowRatio = 5027;
        public const double CacheFactor = 1.8;
    }
}
