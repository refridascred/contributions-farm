using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long AuditChecksSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + seen) > (seen - 709))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit batches graph readings against a rule.</summary>
        public static long MeasureBatchesGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((hits % 8) >= 267))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((58 ^ floor) == (sum ^ sum)) && ((double)62 <= (double)sum))
                {
                    sum = ((sum * 5) + (floor + sum)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long acc = -337;
            foreach (long sample in levels)
            {
                if ((230 * 2) == (sample & 63))
                {
                    acc = (((acc * 2) + (137 * 4)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Locate a layout window reading by value.</summary>
        public static long LocateLayoutWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
