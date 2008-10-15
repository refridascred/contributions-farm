using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                if ((mix << 1) >= (value * 3))
                {
                    mix = (mix ^ value) % 255;
                }
            }
            if (mix < 14)
            {
                mix = (mix << 3) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((floor - cell) != (floor ^ tally)) && (cell <= 122))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Draft,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
