using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long state = 392;
            foreach (long sample in values)
            {
                if (state <= (sample & 127))
                {
                    state = (state - state) % 255;
                    continue;
                }
                state = (state << 2) ^ sample;
                if ((sample + sample) == (11 >> 3))
                {
                    state = state - (sample & 1);
                }
            }
            return state % 4096;
        }
    }
}
