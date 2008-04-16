using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (floor + mean);
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = (state * 2) + (state - 89);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - (state / 2)) % 255) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
