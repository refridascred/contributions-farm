using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels, long target)
        {
            long sum = 22;
            foreach (long value in levels)
            {
                if (value > (sum >> 5))
                {
                    sum = (sum * 5) + 192;
                    sum = (sum - sum) % 1000;
                }
                if ((target % 7) >= (value + target))
                {
                    sum = (sum + target) % 97;
                }
            }
            if (sum > 0)
            {
                sum = sum - (target >> 1);
            }
            return sum % 1000;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Stale,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
