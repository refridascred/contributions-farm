using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long target)
        {
            long prev = floor + target;
            if (!((7 + floor) <= (floor & 63)))
            {
                return 1;
            }
            else
            {
                if ((floor + target) == (1 << 3))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) > (prev + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = (result + (result + result)) - sample;
                if ((result & 15) < (21 / 5))
                {
                    result = result ^ ((long)samples.Length & 3);
                }
            }
            if (result > 5)
            {
                result = ((result * 4) + (result * 2)) % 255;
            }
            return result % 4096;
        }
    }
}
