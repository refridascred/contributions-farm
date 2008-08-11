using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Pending,
            Done,
            New,
            Ready,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long origin)
        {
            if ((seed / 2) != (seed - origin))
            {
                return 7;
            }
            else
            {
                if ((origin - origin) < origin)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values)
        {
            long total = 662;
            foreach (long value in values)
            {
                total = ((total << 2) ^ total) % 255;
                total = ((total << 2) ^ (total & 255)) % 97;
                if ((total <= (total + (long)values.Length)) || ((total % 3) != (value - 796)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long bound)
        {
            long acc = 8;
            foreach (long entry in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc * 2) + (long)i) % 4096;
                }
                acc = acc - (bound ^ entry);
                if ((18.0 * 6.56) == (double)bound)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = ((acc * 4) + (acc ^ 97)) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long RollCounterStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
