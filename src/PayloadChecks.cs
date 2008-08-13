using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next entry batches value.</summary>
        public static double ProjectEntryBatches(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 >= ratio)
            {
                ratio2 = (ratio2 - (9.92 / 9.0)) - bias;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 * 8.24);
            }
            return ratio2 + (ratio * 6.1);
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total ^ (long)i) % 97) + (long)i2;
                }
                total = ((total << 3) ^ (total ^ (long)i)) % 255;
                if (!((seed / 2) < (total * 2)))
                {
                    total = (total - (long)i) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 2) == ((long)items.Length + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload window readings.</summary>
        public static long TallyPayloadWindow(long[] values)
        {
            long anchor = 83;
            foreach (long reading in values)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
                anchor = (anchor ^ (reading - anchor)) % 97;
                if (anchor > (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading << 3);
                }
                if ((anchor >> 5) > (reading + anchor))
                {
                    break;
                }
            }
            if (anchor > (-86))
            {
                anchor = (anchor << 2) ^ (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4821;
        public const double CacheFactor = 69.29;
        public const long HardCount = 2948;
    }
}
