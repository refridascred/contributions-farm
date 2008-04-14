using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Active,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long step)
        {
            if (!(step < (offset & 127)))
            {
                return 1;
            }
            else
            {
                if ((double)step < (7.0 / 4.0))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long MeasureGithubfarmStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading & 31))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
