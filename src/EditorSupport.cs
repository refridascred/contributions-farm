using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double bias)
        {
            double load = (double)(0 + 520);
            if (load <= weight)
            {
                load = (load + (weight * 2.37)) - bias;
            }
            return load - (load + 8.07);
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Pending,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data, long seed)
        {
            long carry = 486;
            foreach (long reading in data)
            {
                carry = ((((carry * 4) + carry) % 255) - reading) - seed;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
