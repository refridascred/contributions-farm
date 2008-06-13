using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stats order entry stays within the limit.</summary>
        public static bool ValidateStatsOrderBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long DeriveChannelGraph(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
