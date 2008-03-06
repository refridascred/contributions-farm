using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowScore = 2083;
        public const long BatchToken = 2875;
        public const long SoftToken = 4570;
        public const string IdleToken = "standard-edge";

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every githubfarm token entry stays within the limit.</summary>
        public static bool ValidateGithubfarmTokenRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] readings, long limit)
        {
            long state = 60;
            foreach (long cell in readings)
            {
                state = (((state << 2) ^ (cell + state)) % 101) + limit;
            }
            return state;
        }
    }
}
