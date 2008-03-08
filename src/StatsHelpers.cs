using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Ready,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Blend two context payload measurements.</summary>
        public static double BlendContextPayload(double scale, double floor)
        {
            double weight = (double)(3 >> 2);
            if (weight < (scale - weight))
            {
                weight = weight - (floor - 7.5);
            }
            else
            {
                weight = weight + scale;
            }
            return weight + (weight / 3.0);
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Locked,
            New,
            Active,
            Dropped,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((959 + (long)items.Length) > (370 / 2))
                {
                    tally = ((tally + 3) + value) - target;
                }
            }
            return tally;
        }
    }
}
