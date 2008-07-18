using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) < (cell >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer support readings.</summary>
        public static long WeighBufferSupport(long[] levels, long floor)
        {
            long total = 83;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total + (total + total)) % 255) - (long)i) + floor;
                }
                total = ((total * 5) + (value + total)) % 4096;
            }
            if (total > 648)
            {
                total = (total * 5) + 9;
            }
            return total % 4096;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) >= ((-90) + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
