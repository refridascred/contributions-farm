using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the context already series from a seed.</summary>
        public static long SeriesContextAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ step) % 4096;
                result = (result - step) % 65521;
                result = result + ((long)i * 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count counter order pairs that satisfy a relation.</summary>
        public static long CompareCounterOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - 2) != (sample << 1))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
