using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate account command readings against a bound.</summary>
        public static bool ValidateAccountCommandBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long mix = 804;
            foreach (long item in samples)
            {
                if ((item << 1) > item)
                {
                    mix = (mix ^ 1) % 97;
                }
            }
            if (mix > (-55))
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "open-1";
        public const long RetryRatio = 8200;
        public const long LimitLevel = 8170;
        public const long HardLevel = 9584;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long sum = 52;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum ^ entry) % 97) ^ (long)i;
                }
                sum = ((sum * 5) + (entry % 97)) % 101;
                sum = (sum * 5) + entry;
            }
            return sum;
        }
    }
}
