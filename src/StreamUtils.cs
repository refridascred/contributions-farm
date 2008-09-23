using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1042;
        public const string WindowInterval = "latest-1";
        public const double MinCache = 10.46;
        public const long MaxSize = 9791;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (origin << 2)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                state = ((state + (long)items.Length) % 1000) + reading;
            }
            return state;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Paused,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load + load) + gain;
            }
            else
            {
                load = load - (double)29;
            }
            return load - (double)8;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Queued,
            Paused,
            Stale,
            Closed,
            Idle,
        }
    }
}
