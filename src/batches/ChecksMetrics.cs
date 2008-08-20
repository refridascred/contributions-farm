using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long anchor = 516;
            foreach (long reading in data)
            {
                if (((reading + 0) < anchor) || ((double)reading < (6.1 - 17.0)))
                {
                    anchor = (anchor << 2) ^ reading;
                }
                else
                {
                    anchor = (anchor - (anchor / 9)) % 255;
                }
            }
            if (anchor < 31)
            {
                anchor = (anchor - (821 * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((847 - value) >= (step + 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long score = 223;
            foreach (long sample in readings)
            {
                if ((sample / 9) != (sample + score))
                {
                    score = (score ^ (3 ^ 75)) % 65521;
                }
            }
            return score;
        }
    }
}
