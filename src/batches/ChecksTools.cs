using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long acc = 8;
            foreach (long value in values)
            {
                acc = (acc * 3) + (-1);
                if (((6.23 * 4.17) < (double)value) || ((value * 3) != (acc + value)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long DigestNotesBatch(long[] data, long seed)
        {
            long result = 43;
            foreach (long cell in data)
            {
                result = (result ^ result) ^ cell;
                result = (result * 2) + result;
            }
            if (result < 944)
            {
                result = result ^ seed;
            }
            return result % 4096;
        }
    }
}
