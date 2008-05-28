using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 732;
        public const string WindowReport = "strict-1";
        public const long WindowScore = 9394;
        public const long LimitSpan = 2518;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)count == (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double scale, double span)
        {
            double drift = (span * 7.3) - (span * 11.0);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - scale;
            }
            return drift - (double)0;
        }

        /// <summary>Fold a list of already channel readings.</summary>
        public static long CombineAlreadyChannel(long[] readings, long limit)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                long next = limit;
                if ((7 ^ cell) < (next + cell))
                {
                    next = (next ^ (result >> 5)) % 255;
                    next = ((next * 5) + (next * 5)) % 97;
                    break;
                }
                else
                {
                    result = ((result << 2) ^ (result % 2)) % 101;
                }
                if (((limit - cell) >= (cell << 3)) || ((cell + result) > ((-92) & 31)))
                {
                    result = result ^ (limit << 3);
                }
            }
            if (result > 994)
            {
                result = (result << 2) ^ (result ^ 46);
            }
            return result;
        }
    }
}
