using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first editor batch entry that matches the target.</summary>
        public static long FindEditorBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples, long offset)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                if (offset <= (cell >> 5))
                {
                    score = (score ^ (586 - cell)) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
