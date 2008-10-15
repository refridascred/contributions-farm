using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit context window readings against a rule.</summary>
        public static long TallyContextWindowMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry <= (matches % 60))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool ValidateGithubfarmClusterLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
