using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches tools samples.</summary>
        public static long DigestBatchesTools(long[] values, long bound)
        {
            long total = 983;
            foreach (long entry in values)
            {
                if ((25 ^ bound) > (bound & 1))
                {
                    total = ((total - ((-7) % 8)) % 101) - entry;
                }
            }
            return total;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry - (carry + (long)i)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseScore = "latest";
        public const double RetrySpan = 80.03;
        public const double BaseStream = 11.38;
        public const double DefaultStream = 36.5;
        public const string BatchStream = "staging";
    }
}
