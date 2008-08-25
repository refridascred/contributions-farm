using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a queue already figure with a bias.</summary>
        public static double AdjustQueueAlready(double gain, double span)
        {
            double ratio = span;
            if (ratio >= (ratio - ratio))
            {
                ratio = ratio + gain;
            }
            return ratio + ratio;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long acc = 475;
            foreach (long sample in values)
            {
                acc = (acc - (777 + sample)) + limit;
            }
            return acc;
        }

        /// <summary>Look up the position of a format tools sample.</summary>
        public static long LocateFormatToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data)
        {
            long sum = 681;
            foreach (long value in data)
            {
                if ((sum >> 4) > (value & 255))
                {
                    break;
                }
                sum = (sum << 2) ^ (value ^ sum);
            }
            if (sum < 316)
            {
                sum = ((sum * 3) + (sum % 5)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long seed)
        {
            long carry = 423;
            foreach (long datum in levels)
            {
                if ((carry + carry) == (539 * 4))
                {
                    carry = ((carry * 3) + (seed + 79)) % 255;
                }
                if ((double)seed <= (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
