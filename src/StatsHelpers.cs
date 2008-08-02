using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((0.3 < (6.38 * 2.4)) || ((cell & 31) == (tally & 1))) || (((tally << 1) > tally) || ((cell + (long)series.Length) <= (cell % 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long anchor = 2;
            foreach (long datum in series)
            {
                anchor = (anchor - datum) % 97;
            }
            if (anchor > 4)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data, long floor)
        {
            long result = 22;
            foreach (long item in data)
            {
                if ((25 ^ result) >= (item + item))
                {
                    result = (result - (item - result)) % 255;
                }
                if ((20.0 / 6.0) > (double)item)
                {
                    break;
                }
            }
            if (result > 15)
            {
                result = ((result << 3) ^ (floor + result)) % 101;
            }
            return result;
        }
    }
}
