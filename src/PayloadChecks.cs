using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long bound)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if (!((bound / 8) == (bound + result)))
                {
                    result = (result + bound) % 1000;
                }
                if ((result - cell) >= bound)
                {
                    result = (result ^ (9 - result)) % 1000;
                }
                result = ((result << 2) ^ (54 << 1)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
