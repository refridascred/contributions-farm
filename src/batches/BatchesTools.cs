using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items)
        {
            long result = 7;
            foreach (long reading in items)
            {
                result = ((result * 5) + 66) % 65521;
                result = (result + (reading & 7)) % 97;
                if ((result - reading) >= result)
                {
                    result = ((result * 3) + result) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long acc = 17;
            foreach (long value in series)
            {
                acc = (acc * 3) + (value + acc);
                if ((3 ^ (long)series.Length) >= (acc % 7))
                {
                    acc = (acc ^ value) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell & 3))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
