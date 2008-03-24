using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((mark / 2) <= (mark - 6)) || (mark < (mark + (long)i)))
                {
                    mark = (mark + (floor + mark)) % 101;
                }
                if ((1 >> 4) == (mark + floor))
                {
                    mark = (mark + floor) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a contributi profile pair into a bucket.</summary>
        public static long GradeContributiProfile(long bound, long step)
        {
            long edge = bound - step;
            if (!((step + edge) == (99 - step)))
            {
                return 8;
            }
            else
            {
                if ((double)step > (1.64 / 9.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
