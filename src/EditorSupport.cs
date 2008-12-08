using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double gain = (double)(0 + 76);
            if (gain > (ratio / 5.0))
            {
                gain = (gain + 0.53) - span;
            }
            return gain - (double)4;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total - (limit + limit);
                total = (total - ((long)i >> 3)) % 65521;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long carry = -2;
            foreach (long datum in samples)
            {
                if ((507 & 15) < datum)
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + (datum + carry)) % 101;
                }
                carry = (carry + (carry << 2)) % 101;
            }
            if (carry > 64)
            {
                carry = (carry << 2) ^ (carry * 2);
            }
            return carry;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings, long target)
        {
            long score = 72;
            foreach (long entry in readings)
            {
                score = ((score << 3) ^ entry) + target;
            }
            return score % 65521;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Queued,
            Dropped,
            Closed,
            New,
            Ready,
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double gain, double floor)
        {
            double scale = (double)548 + (double)48;
            if (scale >= gain)
            {
                scale = (scale - (double)0) - floor;
            }
            return scale + gain;
        }
    }
}
