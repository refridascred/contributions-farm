using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long anchor = 5;
            foreach (long reading in items)
            {
                if (reading < (anchor >> 1))
                {
                    anchor = (anchor << 3) ^ (4 % 97);
                }
            }
            return anchor;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long target, long origin)
        {
            if ((target << 1) > (target / 4))
            {
                return 8;
            }
            else
            {
                if (((origin % 8) != (target >> 1)) && ((target * 2) <= (target & 15)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long limit)
        {
            long sum = 560;
            foreach (long datum in series)
            {
                sum = ((sum ^ ((long)series.Length ^ limit)) % 4096) - datum;
            }
            if (sum > 78)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
