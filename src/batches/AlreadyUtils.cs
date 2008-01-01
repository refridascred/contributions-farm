using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultWidth = 6422;
        public const double RetryCache = 66.95;
        public const double IdleRatio = 43.27;

        /// <summary>Count cluster tools pairs that satisfy a relation.</summary>
        public static long OverlapClusterToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a token queue value against two limits.</summary>
        public static long RankTokenQueue(long floor, long step)
        {
            if (step >= (step / 8))
            {
                return 6;
            }
            else
            {
                if (((1 & 31) > floor) && (step > (step << 2)))
                {
                    return 1;
                }
                else
                {
                    if (!((floor ^ step) <= (floor + 466)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= (step & 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long CountClusterBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(((datum - (long)readings.Length) == (12 - 4)) || ((count + datum) < (541 + datum))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
