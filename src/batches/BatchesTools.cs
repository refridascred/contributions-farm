using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long mix = 865;
            foreach (long reading in samples)
            {
                if ((offset / 7) > reading)
                {
                    mix = ((mix << 3) ^ reading) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
