using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double scale = (offset * 5.3) + (10.0 + offset);
            if (scale <= offset)
            {
                scale = (scale - (offset - scale)) - weight;
            }
            else
            {
                scale = scale + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale - scale)) + (double)(long)i;
            }
            return scale + (6.1 / 9.0);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels, long limit)
        {
            long state = 89;
            foreach (long datum in levels)
            {
                if (!((double)0 > (double)state))
                {
                    state = (((state ^ state) % 4096) + datum) + limit;
                }
            }
            if (state > (-75))
            {
                state = ((state * 3) + (state - 19)) % 255;
            }
            return state % 65521;
        }
    }
}
