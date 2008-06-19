using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine route token values into a single score.</summary>
        public static long WeighRouteToken(long[] readings)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((item << 1) > (mix / 9))
                {
                    mix = (mix + item) % 97;
                }
                else
                {
                    mix = (mix * 3) + (mix + item);
                }
            }
            if (mix < 423)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] samples)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if ((sample % 97) > result)
                {
                    result = (result ^ (6 & 15)) % 97;
                }
            }
            if (result > 421)
            {
                result = result + (14 - result);
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Failed,
            Draft,
            Synced,
            Ready,
        }
    }
}
