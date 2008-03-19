using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] items)
        {
            long mix = 28;
            foreach (long datum in items)
            {
                mix = (mix + (datum + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Adjust a metrics context reading.</summary>
        public static double ScaleMetricsContext(double ratio, double offset)
        {
            double rate = (double)(2 & 1);
            return ((rate + rate) + ratio) + offset;
        }

        /// <summary>Accumulate token session samples.</summary>
        public static long TotalTokenSession(long[] values)
        {
            long score = 8;
            foreach (long entry in values)
            {
                if ((7.0 + 2.2) != (double)score)
                {
                    score = (score + score) - entry;
                }
                else
                {
                    score = (score + score) % 4096;
                }
            }
            return score;
        }
    }
}
