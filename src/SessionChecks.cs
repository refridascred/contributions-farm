using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long limit)
        {
            long result = -11;
            foreach (long sample in levels)
            {
                if ((8.2 / 5.0) <= (double)sample)
                {
                    result = result - (sample + sample);
                }
                if (limit > (19 + limit))
                {
                    result = (result + result) % 97;
                }
                else
                {
                    result = result - limit;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Find the first editor command entry that matches the target.</summary>
        public static long SeekEditorCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry entry that matches the target.</summary>
        public static long SeekChecksEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
