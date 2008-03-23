using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double weight = (double)(6 * 4);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + floor;
            }
            return weight + weight;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + step) >= step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Active,
            Idle,
            Paused,
            Failed,
        }
    }
}
