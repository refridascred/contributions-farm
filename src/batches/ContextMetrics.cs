using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double floor)
        {
            double mean = 4.8;
            if (mean > floor)
            {
                mean = (mean - (mean * 8.0)) - scale;
            }
            return mean - floor;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 65;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ (26 % 16)) % 4096;
                state = (state + (state + reading)) % 4096;
                if ((9.0 * 18.0) > (double)state)
                {
                    state = (state + (state & 255)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items, long step)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                if (!((entry ^ entry) <= (entry - step)))
                {
                    break;
                }
                if ((acc * 4) < entry)
                {
                    acc = (acc - (step * 2)) % 97;
                }
                if (!((acc << 1) >= entry))
                {
                    break;
                }
            }
            if (acc < 3)
            {
                acc = (acc << 2) ^ (step << 2);
            }
            return acc % 4096;
        }
    }
}
