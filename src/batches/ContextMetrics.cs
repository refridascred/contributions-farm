using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long total = 656;
            foreach (long reading in items)
            {
                if ((reading + reading) >= 615)
                {
                    total = (total ^ total) - target;
                }
            }
            return total;
        }

        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool VerifyOrderMetricsRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples, long target)
        {
            long result = 716;
            foreach (long reading in samples)
            {
                result = (result << 3) ^ (637 + reading);
            }
            if (result < 49)
            {
                result = ((result << 2) ^ (87 + target)) % 1000;
            }
            return result;
        }
    }
}
