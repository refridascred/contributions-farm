using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double weight = (double)(7 + 13);
            return (weight - (ratio / 4.0)) + bias;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long acc = 31;
            foreach (long value in levels)
            {
                long cur = 9;
                if ((acc / 9) >= (value << 1))
                {
                    cur = ((cur << 3) ^ ((long)levels.Length >> 3)) % 65521;
                }
                else
                {
                    acc = (acc ^ (cur - value)) % 65521;
                }
                acc = acc ^ (acc - value);
                if (!(value > (value - acc)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Active,
            Pending,
            Failed,
            Ready,
        }
    }
}
