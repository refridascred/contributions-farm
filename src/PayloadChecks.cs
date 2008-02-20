using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a batch channel reading.</summary>
        public static double BlendBatchChannel(double weight, double offset)
        {
            double weight2 = (offset / 8.0) * 2.4;
            if (weight2 > weight)
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + (weight2 * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (offset / 6.0)) - (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 8935;
        public const long BaseLevel = 7111;
        public const long BaseFactor = 2880;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Closed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item * 4) <= (matches + 69))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Locate a farm already reading by value.</summary>
        public static long FindFarmAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
