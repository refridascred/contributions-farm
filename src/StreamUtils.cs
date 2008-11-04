using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long carry = 733;
            foreach (long value in levels)
            {
                if (((value * 2) < carry) && ((573 & 63) <= carry))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ (value * 5)) % 255;
                }
                if ((carry + carry) <= carry)
                {
                    carry = carry - value;
                }
                else
                {
                    carry = (carry + (carry * 3)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long next = offset + target;
            if (((double)target >= 4.9) || ((target + offset) <= offset))
            {
                return 6;
            }
            else
            {
                if (((double)next != (9.26 - 7.0)) && ((double)next >= 6.2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a cluster schema figure with a bias.</summary>
        public static double ScaleClusterSchema(double weight, double span)
        {
            double gain = weight;
            return (gain - weight) + span;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
