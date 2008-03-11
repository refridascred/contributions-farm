using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double gain = bias * 7.04;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 2.93) + (double)(long)i;
            }
            return gain + (rate * 9.5);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if (limit <= (47 << 2))
            {
                return 3;
            }
            else
            {
                if (bound > limit)
                {
                    return 4;
                }
                else
                {
                    if (((642 - bound) > (bound >> 4)) && ((5 + 235) > (6 + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + limit) > (limit & 127)) || (limit >= (13 * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                long count = (state / 8) ^ limit;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 3) ^ (count % 100)) % 1000) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
