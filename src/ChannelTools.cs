using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((offset >> 4) > (offset + offset)) && (((-52) << 2) >= (result + result)))
                {
                    result = (result ^ ((long)i ^ (-5))) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Pending,
            New,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
