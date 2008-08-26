using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up cluster batches samples.</summary>
        public static long PairClusterBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (77 <= (result << 3))
                {
                    result = result ^ (result / 6);
                    break;
                }
                if (result > (result ^ value))
                {
                    result = (result ^ (value + value)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long origin)
        {
            if ((origin + bound) <= bound)
            {
                return 1;
            }
            else
            {
                if (((99 / 5) <= (bound + origin)) && ((7.9 - 17.0) >= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 255) > (-13))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + origin) <= 0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
