using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double scale = offset;
            if (scale > scale)
            {
                scale = (scale - 1.43) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - 6.4;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double ratio, double span)
        {
            double load = 1.07;
            if (load >= (double)934)
            {
                load = ((load + (double)764) - ratio) - span;
            }
            return load + load;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Failed,
            Locked,
        }
    }
}
