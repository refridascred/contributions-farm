using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count format record pairs that satisfy a relation.</summary>
        public static long CompareFormatRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a entry checks figure with a bias.</summary>
        public static double ProjectEntryChecks(double bias, double bias2)
        {
            double ratio = bias2 / 4.0;
            if (ratio <= (bias2 / 2.0))
            {
                ratio = ratio - (bias - bias2);
            }
            else
            {
                ratio = ratio - bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (double)56;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long DeriveContributiTools(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 2) ^ (step - result);
                if (step > result)
                {
                    result = result + step;
                }
                else
                {
                    result = (result - (89 << 1)) % 97;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
