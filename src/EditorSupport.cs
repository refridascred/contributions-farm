using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (552 >> 1))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Queued,
            Pending,
            New,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8803;
        public const long HardSpan = 7834;
        public const long SoftLevel = 1635;
        public const string RetrySession = "primary-1";
        public const long MinSession = 3395;

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double load = gain;
            if (load > floor)
            {
                load = load + floor;
            }
            return load + gain;
        }
    }
}
