using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - 296) == (tally ^ item))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(sum <= (limit >> 3)))
                {
                    sum = sum + (long)i;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2322;
        public const long IdleCount = 6481;
        public const string LimitTimeout = "legacy-edge";
    }
}
