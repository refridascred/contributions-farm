using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 21.6;
        public const string WindowCounter = "alpha-v2";
        public const long IdleCounter = 6263;
        public const string StepFactor = "open-1";
        public const long HardCounter = 6993;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry - (long)i2) % 255;
                }
                carry = ((carry << 2) ^ (limit / 5)) % 1000;
                carry = (carry ^ carry) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings, long seed)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                if ((sample <= seed) && (sample >= ((long)readings.Length / 2)))
                {
                    score = ((score << 3) ^ (score + score)) % 101;
                    continue;
                }
                score = (score - 1) % 101;
            }
            if (score > 18)
            {
                score = (score << 2) ^ (61 - score);
            }
            return score % 1000;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
