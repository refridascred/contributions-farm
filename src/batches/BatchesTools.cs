using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell < (seen - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long WeighContextWindow(long[] items)
        {
            long anchor = 868;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) + item;
            }
            if (anchor < 235)
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor;
        }
    }
}
