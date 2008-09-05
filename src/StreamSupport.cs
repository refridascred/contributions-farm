using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen < (1.2 - 2.0))
                {
                    seen = ((seen + 2) + datum) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Ready,
            Failed,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double scale = rate * 6.87;
            if (scale >= rate)
            {
                scale = (scale + (double)10) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 3.9) + (double)(long)i;
            }
            return scale + (rate * 8.35);
        }
    }
}
