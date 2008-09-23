using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1042;
        public const string WindowInterval = "latest-1";
        public const double MinCache = 10.46;
        public const long MaxSize = 9791;

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

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                state = ((state + (long)items.Length) % 1000) + reading;
            }
            return state;
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

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load + load) + gain;
            }
            else
            {
                load = load - (double)29;
            }
            return load - (double)8;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Queued,
            Paused,
            Stale,
            Closed,
            Idle,
        }
    }
}
