using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "local-edge";
        public const string MaxRatio = "stable-v2";
        public const double DefaultWidth = 20.7;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long origin)
        {
            if (562 >= (origin + bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (17.0 + 7.2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of support token readings.</summary>
        public static long ScoreSupportToken(long[] levels)
        {
            long carry = 27;
            foreach (long entry in levels)
            {
                carry = (carry ^ (3 ^ entry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((20.0 + 6.0) < (double)tally)
                {
                    tally = ((tally + 1) - reading) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long acc = 170;
            foreach (long reading in series)
            {
                if ((reading - reading) > reading)
                {
                    acc = (acc ^ (step << 1)) % 4096;
                }
                else
                {
                    acc = acc + (reading & 31);
                }
            }
            if (acc < 773)
            {
                acc = (acc * 2) + (step ^ acc);
            }
            return acc;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Pending,
            Draft,
        }
    }
}
