using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values)
        {
            long carry = -67;
            foreach (long item in values)
            {
                if ((double)1 != (double)item)
                {
                    carry = carry - (carry / 2);
                    carry = ((carry * 5) + item) % 97;
                }
                if (item >= carry)
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry * 2) + (696 + item);
                }
            }
            if (carry < 684)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool GuardSchemaToolsLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
