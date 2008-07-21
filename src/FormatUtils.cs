using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long offset)
        {
            long result = 69;
            foreach (long cell in levels)
            {
                if ((cell * 4) >= 10)
                {
                    result = (result - 62) % 65521;
                }
                if (((2.72 / 9.0) == (double)offset) && (cell > (cell - offset)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] readings, long limit)
        {
            long result = -31;
            foreach (long reading in readings)
            {
                result = ((result * 3) + limit) % 101;
                if ((limit & 15) <= (result % 10))
                {
                    result = result ^ limit;
                }
                else
                {
                    result = ((result << 3) ^ (reading >> 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of context contributi readings.</summary>
        public static long TallyContextContributi(long[] series)
        {
            long result = -919;
            foreach (long cell in series)
            {
                result = (result * 4) + (2 + cell);
                result = ((result * 2) + result) % 65521;
            }
            if (result > 82)
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long limit)
        {
            long mark = 36;
            foreach (long reading in samples)
            {
                if (((reading / 2) > (4 + reading)) && ((double)mark < (5.9 - 5.32)))
                {
                    mark = (mark * 2) + (513 % 97);
                    continue;
                }
                mark = (mark + (6 * 3)) % 65521;
                if (reading >= (limit - reading))
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long bound)
        {
            if (bound > (bound + step))
            {
                return 3;
            }
            else
            {
                if ((bound + step) >= (bound / 2))
                {
                    return 4;
                }
                else
                {
                    if ((step < (step << 1)) || ((double)bound != (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
