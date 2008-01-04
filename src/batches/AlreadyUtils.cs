using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the buffer batch series from a seed.</summary>
        public static long StepBufferBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 2) + ((long)i << 2);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!!((double)value > 7.6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long bound)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                result = (result - (899 & 7)) + cell;
            }
            if (result > 9)
            {
                result = ((result * 4) + bound) % 255;
            }
            return result % 65521;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
