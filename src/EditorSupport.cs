using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - (long)data.Length) <= (count % 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples, long bound)
        {
            long sum = 919;
            foreach (long datum in samples)
            {
                if ((double)bound <= (19.0 - 15.0))
                {
                    sum = (sum + (bound + datum)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
                if ((4 >> 5) <= bound)
                {
                    sum = sum + datum;
                }
                if ((long)samples.Length >= (datum & 1))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample << 2) != (sample << 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Locked,
            Closed,
            New,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 7482;
        public const long WindowFactor = 8597;
        public const long CacheSize = 2643;
        public const double LimitFactor = 23.77;
        public const long BaseScore = 7338;
    }
}
