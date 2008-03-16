using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long floor)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                if ((mix >= (mix ^ 50)) || ((3 - mix) <= (5 + floor)))
                {
                    mix = ((mix << 3) ^ datum) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
