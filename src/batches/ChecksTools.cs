using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) > ((long)values.Length / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
