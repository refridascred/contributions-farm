using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Active,
            Pending,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long total = 151;
            foreach (long value in samples)
            {
                total = total + (377 + value);
            }
            return total % 1000;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double scale = 1.4 - (double)(-93);
            if (scale <= (scale - 20.0))
            {
                scale = (scale + (0.1 / 7.0)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + weight;
        }
    }
}
