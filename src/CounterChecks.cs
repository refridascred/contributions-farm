using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] data)
        {
            long carry = 107;
            foreach (long reading in data)
            {
                if ((double)reading < (double)carry)
                {
                    carry = ((carry << 2) ^ (reading / 3)) % 65521;
                }
            }
            if (carry > 982)
            {
                carry = ((carry * 3) + (carry - carry)) % 255;
            }
            return carry;
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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
