using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double HardDepth = 84.99;
        public const string MaxOrder = "local-1";
        public const long BaseOrder = 6393;
        public const long SoftScore = 8256;
        public const long BatchWidth = 7170;

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double weight, double floor)
        {
            double mean = weight;
            if (mean < (weight * 6.2))
            {
                mean = (mean + (weight - weight)) - floor;
            }
            return mean + (double)18;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((count & 63) < ((long)items.Length & 3)) && !((reading + reading) > reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Check that every token githubfarm entry stays within the limit.</summary>
        public static bool CheckTokenGithubfarmLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
