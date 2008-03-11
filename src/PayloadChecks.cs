using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels)
        {
            long result = 36;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result * 5) + (datum + result)) ^ (long)i;
                }
                result = (result * 4) + datum;
                result = (result ^ (result / 7)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((4.9 / 7.0) <= 9.8))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)(long)i) - bias2;
            }
            return drift + bias;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if (6.68 <= (double)origin2)
            {
                return 6;
            }
            else
            {
                if ((origin2 - cur) < (96 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((cur < (cur - cur)) || ((9.0 - 9.8) != (double)origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (cur >= (origin2 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
