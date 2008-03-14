using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long sum = 54;
            foreach (long value in items)
            {
                if (!((519 << 2) >= (sum * 3)))
                {
                    sum = (sum + value) % 101;
                }
                else
                {
                    sum = sum ^ (sum + (long)items.Length);
                }
            }
            if (sum > 9)
            {
                sum = (sum + (sum >> 2)) % 255;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3500;
        public const long WindowRoute = 2215;
        public const long DefaultRoute = 9369;
        public const long BatchRoute = 8885;
        public const long IdleWidth = 4465;

        /// <summary>Look up the position of a command batches sample.</summary>
        public static long FindCommandBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
