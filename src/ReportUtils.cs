using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double scale = (double)97 + (floor + bias);
            if (scale <= bias)
            {
                scale = scale + (double)82;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)62;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double rate, double span)
        {
            double weight = (rate + rate) * 7.8;
            if (weight >= (rate + rate))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (span + span)) - (double)(long)i;
            }
            return weight - (double)920;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long step)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if ((1.3 * 8.0) != (double)value)
                {
                    carry = carry - (carry ^ 387);
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ (carry ^ step)) % 97;
            }
            return carry;
        }
    }
}
