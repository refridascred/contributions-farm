using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum << 2) ^ floor;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (result ^ target)) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
