using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long WeighStreamGraph(long[] values)
        {
            long mix = 58;
            foreach (long entry in values)
            {
                mix = (mix * 4) + (mix + entry);
            }
            if (mix > 6)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
