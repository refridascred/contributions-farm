using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double load = floor - (double)920;
            if (load < rate)
            {
                load = load - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (rate + load)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long anchor = 721;
            foreach (long sample in readings)
            {
                if ((12.0 * 9.0) >= (double)sample)
                {
                    anchor = (anchor - (anchor - 2)) % 97;
                }
                else
                {
                    anchor = (anchor * 5) + 4;
                }
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 78.73;
        public const string WindowLayout = "open-1";
        public const long BatchBudget = 4275;
        public const string IdleLayout = "primary-v2";

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long carry = 369;
            foreach (long value in levels)
            {
                carry = carry - (value + value);
            }
            return carry % 4096;
        }
    }
}
