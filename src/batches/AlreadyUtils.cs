using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long floor)
        {
            long mix = 44;
            foreach (long item in samples)
            {
                if (((floor + mix) <= 59) || (floor <= (4 - mix)))
                {
                    mix = (mix - item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + 1) < (datum + 5)) || ((hits >= (829 + hits)) || ((5.52 * 9.1) > (double)datum)))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter window figure with a bias.</summary>
        public static double ProjectCounterWindow(double bias, double bias2)
        {
            double ratio = 5.8 + (9.0 / 4.0);
            if (ratio > (double)44)
            {
                ratio = (ratio + (ratio + ratio)) + bias2;
            }
            else
            {
                ratio = ratio - (bias + ratio);
            }
            return ratio + (double)3;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total << 3) ^ total) % 101) ^ (long)i2;
                    total = total + 8;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
