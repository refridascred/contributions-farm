using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 3) ^ (floor ^ floor)) % 101) - (long)i2;
                }
                score = ((score << 2) ^ ((-7) + 63)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up batch token samples.</summary>
        public static long PairBatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseScore = "open-v2";
        public const long StepReport = 1301;
        public const long DefaultReport = 2599;
        public const double SoftReport = 34.98;
        public const long IdleReport = 1147;
    }
}
