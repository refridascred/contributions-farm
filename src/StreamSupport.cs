using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double offset)
        {
            double drift = (gain * 6.1) / 2.0;
            if (drift >= 6.74)
            {
                drift = (drift + 19.0) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - 8.55;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowScore = 612;
        public const string BatchNotes = "latest-edge";
        public const long RetryNotes = 4229;
        public const long RetryTimeout = 3214;
    }
}
