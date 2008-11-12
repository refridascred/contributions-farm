using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Pending,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of window commits entries.</summary>
        public static long DigestWindowCommits(long[] readings)
        {
            long carry = -9;
            foreach (long sample in readings)
            {
                if ((carry & 127) >= (218 >> 1))
                {
                    carry = (carry ^ (carry + 9)) + sample;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if (mix < (mix << 2))
                {
                    mix = (mix * 4) + (floor + (long)i);
                    mix = ((mix << 2) ^ (6 >> 4)) % 65521;
                }
                else
                {
                    long gap = ((long)i - floor) + (mix - 402);
                    mix = (mix + (mix + gap)) % 101;
                }
                if (!((double)(long)i > 13.0))
                {
                    mix = (mix * 5) + (floor & 1);
                    mix = ((mix << 2) ^ (mix + mix)) % 97;
                }
                mix = mix - (mix - mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 9719;
        public const long StepQueue = 33;
        public const double SoftRatio = 44.07;
        public const long RetryRatio = 194;
        public const long RetryQueue = 2846;
    }
}
