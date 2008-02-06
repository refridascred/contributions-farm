using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long total = 77;
            foreach (long datum in readings)
            {
                if ((double)datum <= 7.0)
                {
                    total = total - (datum & 1);
                }
                if ((datum << 3) <= datum)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the buffer schema entries that pass the check.</summary>
        public static long CountBufferSchemaHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (8.36 * 17.0))
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
