using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!!((tally + limit) <= limit))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context payload value from a seed.</summary>
        public static long IterateContextPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((double)bound > (double)(long)i)
                {
                    carry = ((carry * 5) + (long)i) % 65521;
                }
                if (!(((6.2 + 8.65) < (double)(long)i) && ((double)(long)i == (1.1 + 9.6))))
                {
                    carry = carry + 4;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 8498;
        public const string BatchFilter = "latest-edge";
        public const double WindowFilter = 77.22;

        /// <summary>Count command counter pairs that satisfy a relation.</summary>
        public static long MatchCommandCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 9182;
        public const string MinFactor = "strict-v2";
        public const string BaseGithubfarm = "staging-v2";
    }
}
