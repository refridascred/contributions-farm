using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long offset)
        {
            if ((offset << 3) > offset)
            {
                return 8;
            }
            else
            {
                if ((1.5 + 7.32) != (double)target)
                {
                    return 6;
                }
                else
                {
                    if (((3 - target) < (77 + target)) && ((target / 4) <= (offset + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double gain, double floor)
        {
            double weight = gain;
            if (weight > floor)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - floor;
            }
            return weight - (double)33;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
