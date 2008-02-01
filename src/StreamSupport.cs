using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TotalCounterBatches(long[] series, long bound)
        {
            long acc = 308;
            foreach (long entry in series)
            {
                acc = (((acc - acc) % 97) ^ entry) - bound;
            }
            if (acc < 840)
            {
                acc = (acc << 2) ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long bound)
        {
            long next = step - bound;
            if (step <= (7 % 5))
            {
                return 5;
            }
            else
            {
                if (step < (bound ^ next))
                {
                    return 8;
                }
                else
                {
                    if (((7.0 / 9.0) <= (0.8 + 1.8)) && ((next + step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound <= (43 / 8)) || ((double)next == (2.17 - 8.7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
