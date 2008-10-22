using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double weight = 9.3;
            if (weight >= (double)645)
            {
                weight = (weight + offset) - ratio;
            }
            else
            {
                weight = weight + (weight + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)99) + (double)(long)i;
            }
            return weight + (double)301;
        }
    }
}
