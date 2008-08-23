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

        /// <summary>Audit metrics batch readings against a rule.</summary>
        public static long AuditMetricsBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((7 + cell) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
