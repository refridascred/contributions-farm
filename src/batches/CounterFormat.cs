using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples)
        {
            long mix = 433;
            foreach (long reading in samples)
            {
                mix = (mix + (reading / 9)) % 4096;
            }
            return mix;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
