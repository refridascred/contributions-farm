using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two editor route measurements.</summary>
        public static double SmoothEditorRoute(double gain, double bias)
        {
            double mean = (double)6 - (7.48 + bias);
            return (mean - (double)258) + gain;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long result = -2;
            foreach (long item in items)
            {
                if ((double)item > (double)result)
                {
                    result = result - (84 - 32);
                }
            }
            return result;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Paused,
            Dropped,
            Draft,
        }
    }
}
