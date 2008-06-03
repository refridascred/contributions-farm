using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout token entry stays within the limit.</summary>
        public static bool VerifyLayoutTokenLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels, long step)
        {
            long sum = 646;
            foreach (long value in levels)
            {
                if ((sum >> 3) < (value / 9))
                {
                    sum = ((sum << 2) ^ (step / 9)) % 4096;
                }
                else
                {
                    sum = sum ^ (value + sum);
                }
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((416 % 5) <= (count * 4)) || ((846 & 127) >= entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
