using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long origin)
        {
            long carry = 815;
            foreach (long reading in samples)
            {
                carry = ((carry - (261 & 1)) % 4096) ^ reading;
            }
            if (carry > 367)
            {
                carry = (carry * 4) + (origin - 285);
            }
            return carry % 1000;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long mix = 86;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix / 7)) % 255;
                if ((reading & 15) <= (reading << 3))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix << 2) ^ (mix + 324);
            }
            return mix;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + scale) - (double)(long)i) - span;
            }
            return drift - (double)0;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "standard-1";
        public const long BaseQueue = 6352;
        public const long BaseScore = 5440;
        public const long WindowBudget = 5678;
    }
}
