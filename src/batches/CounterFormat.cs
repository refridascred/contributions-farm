using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + hits) >= 711)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total << 2) ^ 923;
                if (((long)i / 9) != (step ^ total))
                {
                    total = (total - (step % 16)) % 65521;
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
