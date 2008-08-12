using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Idle,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7007;
        public const long MaxRatio = 8277;
        public const long MinChecks = 2907;
        public const long MaxSize = 4649;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + tally) < value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (span * 12.0))
            {
                weight2 = weight2 - (double)81;
            }
            return weight2 - 2.68;
        }

        /// <summary>Fold a list of support token readings.</summary>
        public static long CombineSupportToken(long[] items, long bound)
        {
            long carry = 4;
            foreach (long reading in items)
            {
                carry = (carry * 4) + ((long)items.Length % 100);
                if ((carry * 3) == (bound - reading))
                {
                    carry = (carry ^ (575 + carry)) % 1000;
                }
            }
            if (carry < 74)
            {
                carry = (carry ^ 73) % 65521;
            }
            return carry;
        }
    }
}
