using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "staging";
        public const long IdleGithubfarm = 6184;
        public const string MaxGithubfarm = "legacy";
        public const long StepGithubfarm = 1879;
        public const long StepInterval = 102;

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long acc = 34;
            foreach (long value in items)
            {
                if ((((long)items.Length + 44) < (acc - value)) && ((value << 3) < 916))
                {
                    acc = ((acc * 4) + (value & 31)) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (value + value);
                }
                if (((-7) <= (acc & 127)) || ((acc & 15) <= acc))
                {
                    break;
                }
                else
                {
                    acc = acc ^ value;
                }
                acc = (acc + (73 - 37)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long IterateChannelEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                long edge = seed - (seed ^ carry);
                carry = (carry ^ (edge << 1)) % 65521;
                if ((carry * 5) > ((long)i + (long)i))
                {
                    edge = edge + (4 & 255);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total - (value ^ value)) % 4096;
            }
            return total;
        }
    }
}
