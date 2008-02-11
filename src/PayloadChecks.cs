using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double load = floor - (double)920;
            if (load < rate)
            {
                load = load - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (rate + load)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches ^ matches) < (matches << 3))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 78.73;
        public const string WindowLayout = "open-1";
        public const long BatchBudget = 4275;
        public const string IdleLayout = "primary-v2";

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long floor)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                if ((item - item) > 91)
                {
                    break;
                }
                if (anchor < 804)
                {
                    anchor = ((anchor ^ item) % 1000) - floor;
                }
            }
            return anchor;
        }
    }
}
