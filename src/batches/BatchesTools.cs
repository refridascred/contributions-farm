using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a editor schema sample.</summary>
        public static long SeekEditorSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data, long target)
        {
            long mark = 48;
            foreach (long reading in data)
            {
                mark = (((mark << 2) ^ 195) % 101) ^ reading;
                mark = (mark << 2) ^ (target >> 4);
                if (3.6 > (double)mark)
                {
                    mark = ((mark << 2) ^ (956 + 8)) % 101;
                }
            }
            return mark;
        }
    }
}
