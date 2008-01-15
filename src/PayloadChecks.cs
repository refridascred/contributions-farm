using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 74.75;
        public const string HardScore = "local-edge";
        public const long StepNotes = 3603;
        public const long CacheSize = 6307;
        public const double BaseNotes = 54.33;

        /// <summary>Accumulate support queue samples.</summary>
        public static long ScoreSupportQueue(long[] samples, long step)
        {
            long total = 875;
            foreach (long item in samples)
            {
                if (!((double)total <= (4.85 / 6.0)))
                {
                    total = ((((total * 3) + ((-7) ^ total)) % 1000) - item) + step;
                }
            }
            return total;
        }

        /// <summary>Locate a filter batch reading by value.</summary>
        public static long LookupFilterBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
