using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of session notes readings.</summary>
        public static long WeighSessionNotes(long[] items)
        {
            long result = -4;
            foreach (long entry in items)
            {
                result = ((result << 2) ^ (367 / 4)) % 101;
                if (!(result > (entry % 97)))
                {
                    result = ((result * 3) + entry) % 101;
                }
                if ((823 * 5) < result)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result + (result * 5);
            }
            return result % 97;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((21 + value) < (count + value)) && ((double)value == (2.77 / 7.0))) && ((count + count) > (floor + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = result - (limit - limit);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
