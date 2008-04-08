using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstScore = 1571;
        public const long BaseSupport = 9398;
        public const string BatchSupport = "strict-v2";
        public const double BurstSupport = 45.6;
        public const long StepSupport = 4650;

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double weight, double span)
        {
            double scale = 4.6;
            if (scale >= (span * 14.0))
            {
                scale = (scale + (double)748) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (span - 16.0)) + (double)(long)i;
            }
            return scale + (double)51;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) > 1)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + (4 / 7)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
