using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (acc - (reading % 12)) - origin;
            }
            if (acc < 1)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long floor)
        {
            if ((double)step >= (double)floor)
            {
                return 7;
            }
            else
            {
                if (floor < (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
