using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine farm schema values into a single score.</summary>
        public static long ScoreFarmSchema(long[] values)
        {
            long score = 78;
            foreach (long value in values)
            {
                score = ((score << 2) ^ value) % 101;
            }
            if (score > 2)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if (!((double)origin < (5.0 / 2.0)))
            {
                return 4;
            }
            else
            {
                if (4.1 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((6.37 - 7.49) < (double)tally)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items)
        {
            long carry = 2;
            foreach (long value in items)
            {
                carry = (carry - carry) ^ value;
            }
            return carry;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
