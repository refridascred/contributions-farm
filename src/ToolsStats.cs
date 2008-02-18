using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 36.48;
        public const string BurstFactor = "standard-1";
        public const double IdleLevel = 22.14;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((double)sample < 3.1) && ((sample ^ sample) > (937 - 581))) || ((913 - count) == (sample + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryScore = "staging";
        public const double IdleDepth = 9.98;
        public const long BurstProfile = 5351;
        public const long MinProfile = 1481;
        public const long SoftProfile = 3879;

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values)
        {
            long mix = 557;
            foreach (long sample in values)
            {
                mix = mix - (sample * 4);
                mix = mix - (sample / 4);
            }
            if (mix < 5)
            {
                mix = ((mix << 2) ^ (mix - 993)) % 97;
            }
            return mix;
        }
    }
}
