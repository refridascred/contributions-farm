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

        /// <summary>Fold a list of batches notes readings.</summary>
        public static long CombineBatchesNotes(long[] data)
        {
            long mark = 92;
            foreach (long datum in data)
            {
                mark = mark ^ (53 + datum);
            }
            return mark;
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

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Failed,
            Paused,
            Synced,
            Ready,
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
