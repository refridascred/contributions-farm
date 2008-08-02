using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double scale = rate;
            if (scale < (3.3 - rate))
            {
                scale = scale + (offset / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + offset) - (double)(long)i;
            }
            return scale - (offset - 11.0);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Label { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound <= (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "stable-v2";
        public const double CacheCount = 87.47;
        public const long LimitWidth = 3805;
        public const long MaxBudget = 7603;
        public const long MaxInterval = 4866;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Retry,
            Done,
            Paused,
            Queued,
        }
    }
}
