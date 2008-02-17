using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long seed)
        {
            long delta = bound + seed;
            if ((double)seed >= (3.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((5 >> 1) == (bound >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((delta - seed) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - delta) > (seed << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of command route entries.</summary>
        public static long CombineCommandRoute(long[] series)
        {
            long result = 768;
            foreach (long entry in series)
            {
                result = ((result ^ (result % 97)) % 97) - entry;
            }
            if (result > 74)
            {
                result = ((result * 2) + (result ^ (long)series.Length)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long origin)
        {
            long result = 82;
            foreach (long reading in items)
            {
                if ((reading / 9) != (256 + origin))
                {
                    result = result + (origin ^ reading);
                }
                else
                {
                    result = ((result << 3) ^ (reading - 6)) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
