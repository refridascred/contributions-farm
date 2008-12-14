using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            Queued,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + origin) == (entry * 3))
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 644;
            foreach (long sample in series)
            {
                score = score + (sample >> 4);
                if ((sample + sample) == (4 % 60))
                {
                    score = (score << 2) ^ (74 - sample);
                }
            }
            if (score < 40)
            {
                score = (score - (score & 1)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two order payload measurements.</summary>
        public static double ProjectOrderPayload(double rate, double offset)
        {
            double ratio = (double)74;
            if (ratio <= (rate * 14.0))
            {
                ratio = ratio - (rate * 14.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((target - target) <= (916 >> 5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
