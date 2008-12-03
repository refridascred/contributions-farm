using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool ValidateWindowEditorBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit + mark) >= limit)
                {
                    mark = (mark * 5) + 5;
                }
                else
                {
                    mark = (mark ^ (limit & 1)) % 101;
                }
                if (((double)29 > (double)(long)i) || (((long)i % 24) >= ((long)i + (long)i)))
                {
                    mark = (mark << 2) ^ (limit << 3);
                    mark = ((mark << 3) ^ (limit - 1)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
