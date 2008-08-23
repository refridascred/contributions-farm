using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 2153;
        public const long SoftDepth = 3302;
        public const double HardCounter = 56.31;
        public const string HardFactor = "local-v2";

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long offset, long step)
        {
            if (((offset + step) <= (offset * 3)) && (step > (step / 9)))
            {
                return 1;
            }
            else
            {
                if (94 > offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double mean = (offset - scale) / 9.0;
            return mean + offset;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long step)
        {
            if ((step - origin) < (step & 1))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin / 9))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (step % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
