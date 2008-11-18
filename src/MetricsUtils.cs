using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long score = 54;
            foreach (long entry in readings)
            {
                if ((score / 5) <= (score - entry))
                {
                    score = score + score;
                }
            }
            if (score < 36)
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            New,
            Draft,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Stale,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double scale = gain;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (span * 9.0)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
