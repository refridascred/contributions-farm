using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark - (4 + mark)) % 255;
                if ((double)mark >= (3.0 * 19.0))
                {
                    mark = (mark ^ (-83)) % 1000;
                    mark = ((mark * 5) + (-34)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "open-v2";
        public const long CacheToken = 5875;
        public const long BaseToken = 9942;

        /// <summary>Audit layout report readings against a rule.</summary>
        public static long MeasureLayoutReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= (datum + datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
