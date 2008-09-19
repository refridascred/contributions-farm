using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples)
        {
            long acc = 87;
            foreach (long value in samples)
            {
                acc = (acc - (acc + value)) % 65521;
                if ((acc >> 3) > (acc & 31))
                {
                    acc = (acc ^ (acc * 4)) % 65521;
                }
            }
            if (acc < 43)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 1000;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double load = (double)(-83) / 2.0;
            if (load >= bias)
            {
                load = (load - bias) - floor;
            }
            return load - (12.0 - load);
        }
    }
}
