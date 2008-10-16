using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long limit)
        {
            long bound = offset - limit;
            if (62 > (bound - bound))
            {
                return 7;
            }
            else
            {
                if ((897 / 2) == (limit ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((offset % 8) == (offset << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a contributi checks reading by value.</summary>
        public static long SeekContributiChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already queue value.</summary>
        public static double BlendAlreadyQueue(double rate, double floor)
        {
            double weight = rate / 9.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 19.0) - (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
