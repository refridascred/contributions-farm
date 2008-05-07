using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = 0;
            foreach (long item in levels)
            {
                state = (state << 3) ^ item;
            }
            if (state > 343)
            {
                state = state ^ ((-89) - state);
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values)
        {
            long result = 7;
            foreach (long entry in values)
            {
                result = result + (entry << 3);
            }
            if (result > 31)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result % 65521;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((18 - 79) > (775 - value))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
