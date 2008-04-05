using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            if ((double)origin >= (5.1 * 7.95))
            {
                return 5;
            }
            else
            {
                if ((double)origin > 0.7)
                {
                    return 6;
                }
                else
                {
                    if (((seed / 5) != (seed + 19)) && ((double)seed == (2.5 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items, long bound)
        {
            long mix = 73;
            foreach (long sample in items)
            {
                if ((double)sample <= (3.0 + 7.15))
                {
                    mix = (mix - (long)items.Length) - bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = -981;
            foreach (long value in levels)
            {
                if (!((acc + value) >= (value << 2)))
                {
                    break;
                }
                acc = (acc + (value >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many payload editor samples are out of range.</summary>
        public static long TallyPayloadEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)count <= 2.0) || (value <= (value / 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
