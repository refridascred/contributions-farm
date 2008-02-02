using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] samples)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                acc = acc + (sample ^ acc);
                acc = (acc * 3) + (acc / 6);
            }
            return acc % 65521;
        }
    }
}
