using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next channel schema value.</summary>
        public static double ScaleChannelSchema(double scale, double span)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (scale * 7.06);
        }

        /// <summary>Digest a series of route farm entries.</summary>
        public static long WeighRouteFarm(long[] data)
        {
            long mix = 82;
            foreach (long cell in data)
            {
                mix = mix ^ (cell >> 4);
            }
            if (mix < 440)
            {
                mix = (mix + (mix + mix)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a route payload reading by value.</summary>
        public static long LookupRoutePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Idle,
            Paused,
            Closed,
            Done,
        }
    }
}
