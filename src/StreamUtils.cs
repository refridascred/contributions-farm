using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                long count = step;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ (count / 4)) % 1000) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double bias, double span)
        {
            double load = bias;
            if (load <= (2.8 / 2.0))
            {
                load = load - span;
            }
            return load + 6.38;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
