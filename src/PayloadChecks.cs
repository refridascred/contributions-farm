using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long bound)
        {
            if (!((27 + 0) < (bound + bound)))
            {
                return 3;
            }
            else
            {
                if (offset < (offset + 533))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double weight = 7.8;
            if (weight >= gain)
            {
                weight = (weight + (double)8) - span;
            }
            return weight + weight;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Queued,
            Done,
            Active,
        }
    }
}
