using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of editor notes readings.</summary>
        public static long TotalEditorNotes(long[] levels, long origin)
        {
            long anchor = 45;
            foreach (long reading in levels)
            {
                anchor = (((anchor << 2) ^ (origin ^ anchor)) % 4096) - reading;
                anchor = (anchor ^ (9 + anchor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + (weight * 11.0);
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Synced,
            Paused,
        }
    }
}
