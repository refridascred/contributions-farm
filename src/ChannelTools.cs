using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = total - (total % 2);
                if (!((cell >> 4) < (total - 62)))
                {
                    total = (total << 2) ^ ((long)readings.Length - total);
                }
                total = total ^ 78;
            }
            if (total < 4)
            {
                total = ((total << 3) ^ (811 % 7)) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
