using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double scale = offset - (0.4 * 14.0);
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 6.7;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long step2)
        {
            if (((54 / 4) >= step) && ((step << 1) < step))
            {
                return 3;
            }
            else
            {
                if ((double)step < (double)step2)
                {
                    return 8;
                }
                else
                {
                    if ((double)step2 != (1.41 + 2.1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step2) == (step - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultScore = 5131;
        public const long RetrySchema = 4220;
        public const long DefaultSchema = 6135;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
