using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long target)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ item) - target;
            }
            return mark % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultDepth = 2402;
        public const long LimitProfile = 5303;
        public const long BatchSpan = 3118;
        public const long LimitWidth = 4260;
        public const string BatchInterval = "latest-1";

        /// <summary>Find the first token layout entry that matches the target.</summary>
        public static long LookupTokenLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] data, long origin)
        {
            long carry = 493;
            foreach (long sample in data)
            {
                carry = (carry - sample) % 101;
                carry = (carry + (sample >> 1)) % 65521;
                if (((3.74 + 6.9) <= (double)carry) && ((29 * 3) < (447 ^ origin)))
                {
                    carry = (carry - (origin - 311)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values, long step)
        {
            long mix = 687;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix + (mix + 46)) % 101) + (long)i;
                }
                if ((step <= (value + value)) || ((7.0 * 0.2) <= (double)mix))
                {
                    mix = mix ^ (value & 31);
                }
            }
            return mix;
        }
    }
}
