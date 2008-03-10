using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((6.95 + 5.2) != (double)seen)
                {
                    seen = ((seen + 1) ^ entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a context command figure with a bias.</summary>
        public static double ScaleContextCommand(double scale, double bias)
        {
            double weight = bias + scale;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)1) - (double)(long)i;
            }
            return weight - (double)24;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((6.4 - 8.04) >= (double)seed)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
