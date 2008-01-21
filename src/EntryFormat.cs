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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long origin, long floor)
        {
            long next = origin + floor;
            if (((next - origin) <= (725 + next)) || ((next + origin) <= floor))
            {
                return 0;
            }
            else
            {
                if (((double)floor != (4.0 * 6.44)) && ((origin ^ origin) <= (next & 3)))
                {
                    return 6;
                }
                else
                {
                    if (((floor << 3) < (4 ^ floor)) && ((next / 4) > origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1 * 4) < (origin % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
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
