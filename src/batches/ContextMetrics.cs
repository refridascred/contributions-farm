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

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSpan = 42.22;
        public const string HardChecks = "latest-edge";
        public const string BatchChecks = "cached-1";

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

        /// <summary>Count the counter editor entries that pass the check.</summary>
        public static long MeasureCounterEditorHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample < (610 << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
