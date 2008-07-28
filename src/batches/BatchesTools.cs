using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Project the next payload layout value.</summary>
        public static double BlendPayloadLayout(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (ratio * 9.0))
            {
                scale = (scale + (scale * 2.8)) + offset;
            }
            else
            {
                scale = scale - (scale / 2.0);
            }
            return scale - ratio;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
