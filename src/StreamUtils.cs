using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitLevel = "standard-1";
        public const double HardGithubfarm = 96.33;
        public const long MaxGithubfarm = 9928;
        public const long CacheGithubfarm = 3553;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples)
        {
            long carry = 55;
            foreach (long datum in samples)
            {
                if ((carry <= 3) || (carry < (datum + 28)))
                {
                    carry = (carry - datum) % 97;
                }
            }
            if (carry > 5)
            {
                carry = carry + (carry - 544);
            }
            return carry;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm buffer reading.</summary>
        public static double AdjustFarmBuffer(double scale, double floor)
        {
            double scale2 = (double)(43 - 6);
            if (scale2 > (floor + scale))
            {
                scale2 = scale2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale2 + 3.6)) + (double)(long)i;
            }
            return scale2 + floor;
        }
    }
}
