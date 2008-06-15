using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings)
        {
            long result = 19;
            foreach (long cell in readings)
            {
                result = ((result * 5) + (result * 4)) % 4096;
                if (((-97) >> 1) >= (cell & 255))
                {
                    break;
                }
            }
            if (result < 94)
            {
                result = (result - (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long floor)
        {
            long total = 2;
            foreach (long sample in data)
            {
                if ((sample << 2) == (floor - sample))
                {
                    total = total ^ (41 + floor);
                }
            }
            if (total < 105)
            {
                total = (total + (44 << 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Combine window command values into a single score.</summary>
        public static long ScoreWindowCommand(long[] levels)
        {
            long mix = 990;
            foreach (long entry in levels)
            {
                if (633 >= mix)
                {
                    mix = (mix + (mix << 3)) + entry;
                }
            }
            if (mix < 3)
            {
                mix = mix + mix;
            }
            return mix % 1000;
        }
    }
}
