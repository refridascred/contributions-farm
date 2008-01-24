using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values)
        {
            long carry = 21;
            foreach (long reading in values)
            {
                carry = (carry ^ (reading - reading)) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long offset)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                mix = (mix ^ (offset + mix)) ^ reading;
            }
            if (mix < 53)
            {
                mix = (mix + (8 + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long seed)
        {
            long result = 6;
            foreach (long datum in data)
            {
                result = (((result << 2) ^ (datum % 24)) % 97) - seed;
            }
            return result % 1000;
        }

        /// <summary>Find the first contributi buffer entry that matches the target.</summary>
        public static long SeekContributiBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
