using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "legacy-edge";
        public const long IdleInterval = 4125;
        public const long WindowCommits = 1207;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 7508;
        public const long LimitBudget = 1798;
        public const long StepQueue = 7533;
        public const long WindowQueue = 1407;

        /// <summary>Iterate the editor command series from a seed.</summary>
        public static long IterateEditorCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                long slot = (limit / 4) & 31;
                total = (total << 2) ^ (limit + limit);
                if (!((double)(long)i == (double)slot))
                {
                    total = (total + (-301)) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 56;
            foreach (long entry in data)
            {
                if (!((double)entry != (16.0 - 2.2)))
                {
                    carry = (carry - (95 & 3)) % 101;
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (711 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Find the first layout channel entry that matches the target.</summary>
        public static long FindLayoutChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
