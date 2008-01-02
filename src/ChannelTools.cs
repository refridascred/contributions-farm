using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value + target) != (341 - value)) || ((target <= value) || (target < (750 & 31))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch route readings.</summary>
        public static long PairBatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long MeasureStreamSessionHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((floor % 5) <= (seen ^ seen)))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
