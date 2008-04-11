using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double floor)
        {
            double drift = (double)(6 * 4);
            if (drift > (8.0 / 3.0))
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 5.42) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ seed) % 1000) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)result != (7.78 * 1.0)))
                {
                    result = (result ^ (bound % 24)) % 1000;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
