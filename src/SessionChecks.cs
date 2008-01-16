using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the window checks series from a seed.</summary>
        public static long RollWindowChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed & 15) < (seed - result))
                {
                    result = (result + result) % 4096;
                    break;
                }
                result = result + (result << 3);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (offset * 4)) % 97;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context schema samples are out of range.</summary>
        public static long AuditContextSchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum % 5) >= (datum % 60))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
