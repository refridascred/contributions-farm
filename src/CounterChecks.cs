using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinInterval = 0.54;
        public const long CacheBudget = 6751;
        public const long BurstQueue = 831;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if (!(step <= ((-273) - 75)))
                {
                    acc = (acc + (155 - step)) % 65521;
                }
                else
                {
                    acc = (acc * 3) + step;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double floor)
        {
            double drift = (double)(542 << 1);
            return ((drift + drift) + scale) + floor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Locked,
            Active,
        }
    }
}
