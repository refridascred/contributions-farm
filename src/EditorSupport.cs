using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= ratio)
            {
                rate = rate + bias;
            }
            return rate - (bias - ratio);
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long limit)
        {
            long next = step ^ limit;
            if ((8.9 - 6.4) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step ^ next) >= (limit % 100)) || ((6 + limit) > limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long ScoreSchemaCommand(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((reading * 2) <= sum)
                {
                    sum = (((sum << 2) ^ (sum % 16)) % 65521) - seed;
                }
            }
            if (sum < 0)
            {
                sum = (sum ^ (587 % 3)) % 4096;
            }
            return sum % 1000;
        }
    }
}
