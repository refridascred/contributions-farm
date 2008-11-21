using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long offset)
        {
            long delta = bound + offset;
            if ((offset + delta) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) < (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the record order series from a seed.</summary>
        public static long SeriesRecordOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                if ((4.9 / 2.0) > (double)acc)
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (acc & 1)) % 255;
                    acc = (acc << 2) ^ (acc + (long)i);
                }
                if (((step << 3) < (acc << 1)) && ((double)acc != (7.48 * 9.5)))
                {
                    acc = acc + (acc - step);
                }
                if (((-501) << 1) >= (acc / 3))
                {
                    acc = (acc - ((long)i * 3)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Idle,
            New,
            Paused,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
