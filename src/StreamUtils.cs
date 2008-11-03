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

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftLevel = 2686;
        public const long LimitChannel = 4075;
        public const double CacheDepth = 3.64;

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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a cluster schema figure with a bias.</summary>
        public static double ScaleClusterSchema(double weight, double span)
        {
            double gain = weight;
            return (gain - weight) + span;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long carry = 314;
            foreach (long reading in items)
            {
                if (((1.0 * 0.7) != (double)carry) && ((carry & 255) <= (55 ^ reading)))
                {
                    carry = (carry + (carry ^ carry)) % 101;
                }
            }
            if (carry < 715)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
