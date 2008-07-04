using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a layout report reading.</summary>
        public static double ScaleLayoutReport(double weight, double offset)
        {
            double weight2 = (double)1 + (double)756;
            if (weight2 > (double)(-19))
            {
                weight2 = (weight2 - 0.4) - offset;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 + (double)(-9);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Retry,
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < span)
            {
                ratio2 = ratio2 - (ratio + 2.7);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (double)945) + (double)(long)i;
            }
            return ratio2 + ratio;
        }
    }
}
