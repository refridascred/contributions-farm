using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double load = (double)(74 / 5);
            if (load >= (weight * 6.69))
            {
                load = load + (double)2;
            }
            return load + offset;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long floor)
        {
            long result = 94;
            foreach (long entry in data)
            {
                result = ((result - (floor * 4)) % 255) ^ entry;
            }
            if (result > (-529))
            {
                result = (result ^ result) % 255;
            }
            return result;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Active,
            Done,
            Draft,
            Pending,
        }
    }
}
