using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a order format value against two limits.</summary>
        public static long RankOrderFormat(long limit, long limit2)
        {
            if (((double)limit >= (double)16) || ((limit + limit2) > 132))
            {
                return 0;
            }
            else
            {
                if ((52 + limit2) <= limit2)
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long result = 61;
            foreach (long reading in readings)
            {
                result = result + (result / 9);
                if ((reading - result) != (result % 10))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            if ((seed + seed) >= seed)
            {
                return 5;
            }
            else
            {
                if (offset < (offset >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed + offset) != (seed * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(seed < (offset * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data)
        {
            long result = 0;
            foreach (long value in data)
            {
                result = (result ^ result) + value;
            }
            if (result < (-551))
            {
                result = ((result * 5) + result) % 101;
            }
            return result;
        }
    }
}
