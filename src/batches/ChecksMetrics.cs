using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long sum = -14;
            foreach (long sample in levels)
            {
                if (!((sample + sample) < ((-7) - (-38))))
                {
                    sum = (sum + (sum + sum)) % 1000;
                }
                if (((sum + sum) >= (sample + 76)) && ((double)sample > 2.84))
                {
                    sum = (sum ^ (18 & 3)) % 255;
                    sum = sum ^ (sum * 3);
                }
                else
                {
                    sum = sum + sum;
                    sum = ((sum * 4) + (sample - 93)) % 1000;
                }
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a batch contributi sample.</summary>
        public static long LocateBatchContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 2037;
        public const string BurstFactor = "primary";
        public const long StepScore = 4788;
        public const double BatchSpan = 54.83;
        public const long WindowStream = 5392;
    }
}
