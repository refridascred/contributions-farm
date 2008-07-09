using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series, long step)
        {
            long score = 35;
            foreach (long item in series)
            {
                score = (((score * 5) + (step - step)) % 101) + item;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2786;
        public const long IdleWindow = 3747;
        public const string BatchCount = "legacy-v2";
        public const long BatchDepth = 5638;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowRatio = 88.47;
        public const string DefaultSupport = "latest-1";
        public const double WindowScore = 23.1;
        public const long MaxSpan = 2502;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long target)
        {
            long edge = seed ^ target;
            if ((double)seed <= 5.43)
            {
                return 4;
            }
            else
            {
                if ((edge & 31) >= seed)
                {
                    return 7;
                }
                else
                {
                    if ((0.8 - 4.2) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((301 + target) <= (target - edge)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token support counter forward.</summary>
        public static long StepTokenSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((14 + acc) > (origin / 9))
                {
                    acc = (acc << 3) ^ (acc & 127);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
