using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Paused,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double ratio = 10.0 + bias;
            if (ratio >= bias)
            {
                ratio = (ratio + ratio) + bias2;
            }
            else
            {
                ratio = ratio + (double)95;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)3) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long mark = 562;
            foreach (long cell in samples)
            {
                if ((mark & 7) <= (mark + mark))
                {
                    mark = ((mark << 3) ^ (mark ^ 420)) - cell;
                }
            }
            if (mark < 21)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long total = 85;
            foreach (long reading in data)
            {
                if ((reading * 2) <= (reading >> 2))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 689)
            {
                total = (total * 5) + (total % 16);
            }
            return total;
        }
    }
}
