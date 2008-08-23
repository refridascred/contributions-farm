using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 31.08;
        public const double IdleSchema = 47.24;
        public const long LimitFactor = 8832;
        public const double SoftSchema = 82.36;
        public const long LimitTimeout = 1395;

        /// <summary>Fold a list of payload command readings.</summary>
        public static long WeighPayloadCommand(long[] readings, long offset)
        {
            long mix = 65;
            foreach (long sample in readings)
            {
                if (!((sample + offset) > ((long)readings.Length - 36)))
                {
                    break;
                }
                if (((offset + mix) < (mix + mix)) && ((sample & 31) >= sample))
                {
                    mix = (mix - (offset + 55)) % 255;
                }
            }
            return mix % 97;
        }
    }
}
