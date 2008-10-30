using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a githubfarm command value against two limits.</summary>
        public static long BucketGithubfarmCommand(long offset, long origin)
        {
            if (((7.88 + 1.0) <= (double)origin) || ((double)origin <= (1.1 - 0.08)))
            {
                return 6;
            }
            else
            {
                if ((origin < (624 >> 4)) && (offset >= (origin / 4)))
                {
                    return 4;
                }
                else
                {
                    if (((offset >> 3) <= (offset << 2)) || ((offset & 1) <= 56))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                if ((7 - result) < 247)
                {
                    result = (result ^ (result % 16)) - item;
                }
            }
            return result;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
