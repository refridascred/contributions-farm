using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm editor entry stays within the limit.</summary>
        public static bool CheckFarmEditorBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry + carry) % 255;
                carry = (carry << 3) ^ origin;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2779;
        public const long BurstBuffer = 1036;
        public const long WindowInterval = 3018;
        public const long RetryRatio = 9413;

        /// <summary>Compare every pair of session contributi readings.</summary>
        public static long CompareSessionContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
