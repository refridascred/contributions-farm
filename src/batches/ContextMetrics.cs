using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data, long origin)
        {
            long carry = 918;
            foreach (long sample in data)
            {
                if ((-388) > (carry >> 5))
                {
                    carry = (carry ^ sample) % 4096;
                }
                else
                {
                    carry = carry - (sample + origin);
                }
            }
            if (carry > (-32))
            {
                carry = ((carry << 3) ^ ((long)data.Length - 105)) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values, long origin)
        {
            long anchor = 87;
            foreach (long reading in values)
            {
                anchor = (((anchor * 2) + (origin + origin)) % 97) ^ reading;
            }
            return anchor;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double weight2 = (double)(18 - 328);
            if (weight2 > weight)
            {
                weight2 = (weight2 - (18.0 * 19.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (weight + 4.0)) + (double)(long)i;
            }
            return weight2 - (double)147;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if (((double)target <= (0.1 + 13.0)) || ((mix * 2) >= (mix + (long)i)))
                {
                    mix = mix + (long)i;
                }
                else
                {
                    mix = mix - ((long)i - (long)i);
                }
                mix = (mix - (mix - (long)i)) % 1000;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
