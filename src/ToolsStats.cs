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

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long origin)
        {
            long total = 6;
            foreach (long sample in levels)
            {
                if (((origin / 3) < (total << 1)) || ((sample - origin) >= 1))
                {
                    total = (total - 2) % 65521;
                }
                if ((double)sample != (7.8 + 3.98))
                {
                    break;
                }
            }
            return total;
        }
    }
}
