using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double floor)
        {
            double drift = (floor - ratio) * 3.6;
            if (drift > (double)83)
            {
                drift = drift + 2.0;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) - (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
