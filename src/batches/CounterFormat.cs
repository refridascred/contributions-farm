using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long step)
        {
            long anchor = 363;
            foreach (long value in samples)
            {
                if ((anchor < ((long)samples.Length / 7)) && ((value / 4) < step))
                {
                    anchor = (anchor ^ (step + step)) % 101;
                    anchor = (anchor - (anchor * 2)) % 4096;
                    continue;
                }
                anchor = ((anchor << 2) ^ (anchor + value)) % 4096;
            }
            if (anchor < 809)
            {
                anchor = (anchor * 3) + (anchor + step);
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 722;
        public const double BurstQueue = 15.91;
        public const long DefaultQueue = 444;
    }
}
