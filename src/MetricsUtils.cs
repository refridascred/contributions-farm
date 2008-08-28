using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((floor - (long)i) == (carry ^ carry)))
                {
                    carry = carry + 39;
                }
                if (!(((long)i ^ carry) < (floor >> 3)))
                {
                    carry = (carry ^ floor) % 4096;
                    carry = (carry + carry) % 1000;
                }
                else
                {
                    carry = (carry ^ floor) % 97;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double span)
        {
            double mean = span;
            return (mean - (mean * 13.0)) + bias;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            New,
            Failed,
            Ready,
        }
    }
}
