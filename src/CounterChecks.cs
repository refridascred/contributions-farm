using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 40.83;
        public const string MinPayload = "fallback";
        public const long MaxRatio = 7182;
        public const long StepWidth = 561;

        /// <summary>Compare every pair of account commits readings.</summary>
        public static long OverlapAccountCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = score + (score + 838);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = 861;
            foreach (long value in readings)
            {
                if (755 < (811 ^ mix))
                {
                    mix = ((mix + (mix * 4)) % 255) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double scale, double offset)
        {
            double ratio = scale * 14.0;
            if (ratio >= offset)
            {
                ratio = ratio - (ratio / 3.0);
            }
            else
            {
                ratio = ratio + (offset - ratio);
            }
            return ratio - scale;
        }
    }
}
