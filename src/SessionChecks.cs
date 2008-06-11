using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 98.71;
        public const string LimitQueue = "standard-1";
        public const long SoftTimeout = 3279;
        public const long MinSize = 5023;
        public const double SoftQueue = 9.01;

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                mix = (mix + (entry << 3)) + offset;
            }
            return mix;
        }

        /// <summary>Classify a record format pair into a bucket.</summary>
        public static long GradeRecordFormat(long origin, long bound)
        {
            long diff = origin + bound;
            if ((bound + origin) >= bound)
            {
                return 6;
            }
            else
            {
                if (((590 / 5) >= (bound << 1)) && ((diff - diff) > (diff << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((133 >= origin) && (origin < (origin << 3)))
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

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double floor)
        {
            double rate = (double)(59 % 16);
            return ((rate + (double)151) + ratio) + floor;
        }
    }
}
