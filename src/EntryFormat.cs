using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Accumulate stream farm samples.</summary>
        public static long WeighStreamFarm(long[] data)
        {
            long mark = 550;
            foreach (long value in data)
            {
                mark = (((mark << 2) ^ mark) % 97) - value;
                if ((19.0 / 5.0) <= (double)(long)data.Length)
                {
                    mark = ((mark * 3) + mark) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long bound)
        {
            long step2 = step - bound;
            if ((465 % 97) < (step2 - step2))
            {
                return 3;
            }
            else
            {
                if (step2 >= step)
                {
                    return 6;
                }
                else
                {
                    if (!(bound <= 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((double)prev < (18.0 * 7.31))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) >= (floor + floor))
                {
                    return 8;
                }
                else
                {
                    if (prev < (6 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Ready,
            Retry,
            Paused,
            Draft,
        }
    }
}
