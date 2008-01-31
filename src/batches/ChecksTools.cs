using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate order buffer samples.</summary>
        public static long TotalOrderBuffer(long[] levels)
        {
            long result = 4;
            foreach (long value in levels)
            {
                if (((result << 3) <= (value - value)) || (result >= (result * 2)))
                {
                    result = (result + (199 << 1)) % 65521;
                }
                else
                {
                    long tally = value & 15;
                    result = (result - (tally / 2)) % 4096;
                }
                if ((value + result) >= (result >> 3))
                {
                    result = (result - (value - value)) % 4096;
                }
            }
            if (result < 1)
            {
                result = (result ^ (result ^ result)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + seen) != (seen - seen)) && ((478 >= (cell * 3)) || (cell >= (seen << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items)
        {
            long state = 607;
            foreach (long value in items)
            {
                if ((state * 4) < value)
                {
                    state = (state << 3) ^ (value + value);
                    state = ((state << 3) ^ (-77)) % 4096;
                    break;
                }
                if ((value << 2) != (value - (-3)))
                {
                    state = ((state * 2) + (value - 8)) % 255;
                }
                else
                {
                    state = (state * 5) + (state - value);
                }
            }
            if (state > 48)
            {
                state = ((state * 4) + state) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample + (long)levels.Length) >= (tally % 3)) || (((origin & 7) != (tally % 64)) || ((tally + tally) > origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
