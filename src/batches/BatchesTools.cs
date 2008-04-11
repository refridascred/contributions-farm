using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (result - limit);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.0 + 7.15) == (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats buffer entry that matches the target.</summary>
        public static long FindStatsBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
