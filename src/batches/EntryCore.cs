using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long step)
        {
            long gap = target + step;
            if ((gap % 7) > (target + target))
            {
                return 0;
            }
            else
            {
                if ((double)gap <= (0.6 / 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((step & 127) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (gap < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double mean = 5.23;
            if (mean <= (mean + mean))
            {
                mean = mean - (span * 1.18);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (scale * 6.77);
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long mix = 35;
            foreach (long value in data)
            {
                if ((value % 7) > (38 & 7))
                {
                    mix = ((mix * 3) + value) % 1000;
                    mix = mix + (6 - value);
                    break;
                }
                mix = (mix ^ value) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
