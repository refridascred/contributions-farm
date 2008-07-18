using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series)
        {
            long total = 16;
            foreach (long reading in series)
            {
                if ((double)reading == (8.0 + 16.0))
                {
                    total = total - (reading << 3);
                }
            }
            if (total > 62)
            {
                total = total - (8 * 4);
            }
            return total % 65521;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch schema entries.</summary>
        public static long TotalBatchSchema(long[] levels)
        {
            long result = -25;
            foreach (long sample in levels)
            {
                result = (result + (result - result)) % 4096;
                if ((sample + result) != (result ^ 8))
                {
                    result = ((result << 3) ^ (575 & 3)) % 255;
                }
                if (((sample + sample) >= (sample / 7)) || ((75 % 97) >= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long step)
        {
            long lane = target + step;
            if ((double)lane == (double)step)
            {
                return 6;
            }
            else
            {
                if ((step + target) <= (step & 63))
                {
                    return 4;
                }
                else
                {
                    if ((1.31 - 4.2) > (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
