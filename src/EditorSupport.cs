using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double load = (double)(507 >> 5);
            if (load >= scale)
            {
                load = load - (span / 3.0);
            }
            else
            {
                load = load + (double)9;
            }
            return load + (16.0 - load);
        }

        /// <summary>Measure how many command token samples are out of range.</summary>
        public static long CountCommandTokenOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((offset - cell) < (count / 5)) || (0.63 >= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
