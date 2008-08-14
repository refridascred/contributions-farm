using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up metric tools samples.</summary>
        public static long CompareMetricToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data)
        {
            long carry = -2;
            foreach (long datum in data)
            {
                if (datum > ((long)data.Length + carry))
                {
                    carry = (carry ^ (datum % 97)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long TallyChecksWindow(long[] levels)
        {
            long carry = -556;
            foreach (long datum in levels)
            {
                if ((datum >> 2) == (datum - 1))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            if (carry > 17)
            {
                carry = ((carry << 3) ^ 0) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheTimeout = 8310;
        public const long BatchStats = 2236;
        public const long MaxDepth = 4193;
        public const long SoftStats = 1278;
        public const double BurstStats = 80.96;
    }
}
