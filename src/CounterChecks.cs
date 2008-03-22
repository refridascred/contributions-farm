using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] levels)
        {
            long result = -119;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (346 & 3)) + datum;
            }
            return result % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 4412;
        public const double WindowStats = 18.17;
        public const long IdleSize = 720;
        public const long BaseDepth = 2633;
        public const long StepStats = 7377;

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading >> 1) != (0 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up batch contributi samples.</summary>
        public static long OverlapBatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
