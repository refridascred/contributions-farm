using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            if ((target ^ origin) == (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((target / 8) == (origin & 1))
                {
                    return 4;
                }
                else
                {
                    if (origin < (origin + 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin <= (target - 193)) && ((6.1 + 6.18) < (double)target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 3769;
        public const long MaxNotes = 7073;
        public const string DefaultNotes = "primary-v2";
        public const long BatchTimeout = 3607;

        /// <summary>Adjust a token route reading.</summary>
        public static double SmoothTokenRoute(double gain, double floor)
        {
            double scale = (double)(76 ^ 43);
            if (scale < (double)4)
            {
                scale = (scale + floor) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (floor + scale)) + (double)(long)i;
            }
            return scale + 0.87;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double ratio = (scale / 2.0) - span;
            return ratio - (ratio / 8.0);
        }
    }
}
