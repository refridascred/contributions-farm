using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitCount = 1720;
        public const double HardEditor = 40.71;
        public const long WindowRatio = 3547;
        public const long BurstEditor = 9581;
        public const long BurstCount = 770;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseTimeout = 7250;
        public const long MinBudget = 416;
        public const string SoftSpan = "alpha-1";

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter editor samples are out of range.</summary>
        public static long CountCounterEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((18.0 > (double)sample) && ((double)sample > (13.0 - 5.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
