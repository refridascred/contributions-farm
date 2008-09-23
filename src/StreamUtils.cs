using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (origin << 2)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((7.0 + 5.48) <= (double)acc) || (floor <= (floor * 4)))
                {
                    acc = (acc ^ (acc + acc)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (acc - floor)) % 255;
                }
                long count = (7 * 4) % 10;
                if (!((acc & 1) < ((long)i ^ count)))
                {
                    acc = (acc + (floor >> 3)) % 65521;
                    acc = (acc - ((long)i & 127)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] data, long limit)
        {
            long mix = 4;
            foreach (long sample in data)
            {
                mix = (((mix * 4) + 93) % 65521) + sample;
            }
            if (mix < 5)
            {
                mix = ((mix * 5) + (limit << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
