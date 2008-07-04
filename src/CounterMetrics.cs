using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.0 + 17.0) == (double)step)
                {
                    acc = (acc * 2) + ((-3) >> 1);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two notes checks measurements.</summary>
        public static double SmoothNotesChecks(double weight, double floor)
        {
            double ratio = (double)(86 + 555);
            if (ratio > (double)61)
            {
                ratio = (ratio - (double)165) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (floor * 16.0)) + (double)(long)i;
            }
            return ratio - (double)74;
        }
    }
}
