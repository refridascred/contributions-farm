using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)step == (2.0 / 7.0)) || (((long)i + step) > (21 * 5)))
                {
                    anchor = (anchor - (step - anchor)) % 97;
                }
                anchor = (anchor ^ ((long)i + anchor)) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 2) + ((long)i2 & 127)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double bias = (double)(48 / 2);
            if (bias > (double)3)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)300) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item >= matches) || (((item % 16) != (item >> 1)) || ((double)item == (6.0 + 5.3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data, long step)
        {
            long carry = 279;
            foreach (long datum in data)
            {
                if (!(199 < step))
                {
                    carry = (carry * 4) + step;
                }
                if ((datum < step) && (carry <= ((-7) - datum)))
                {
                    break;
                }
            }
            if (carry < 237)
            {
                carry = (carry ^ (step / 3)) % 4096;
            }
            return carry % 65521;
        }
    }
}
