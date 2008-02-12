using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route graph samples.</summary>
        public static long DigestRouteGraph(long[] values)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = total - (total + datum);
            }
            return total % 65521;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
