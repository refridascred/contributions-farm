using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate layout record readings against a bound.</summary>
        public static bool ValidateLayoutRecordBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Project the next graph cache value.</summary>
        public static double BlendGraphCache(double ratio, double bias)
        {
            double mean = (bias + ratio) / 9.0;
            if (mean >= 2.78)
            {
                mean = mean + (mean * 2.9);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean + (1.72 * 8.01);
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double ratio = (double)(5 * 4);
            if (ratio >= weight)
            {
                ratio = ratio + (weight / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] values, long seed)
        {
            long anchor = 8;
            foreach (long sample in values)
            {
                anchor = anchor + (seed / 7);
                if ((seed <= sample) && ((seed - 29) != ((-384) + 54)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (floor + carry);
                carry = (carry + ((long)i + 79)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
