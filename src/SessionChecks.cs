using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "latest";
        public const string MinNotes = "latest";
        public const long BatchCount = 1053;
        public const long MaxScore = 8048;

        /// <summary>Compare every pair of batches channel readings.</summary>
        public static long PairBatchesChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples, long floor)
        {
            long state = 217;
            foreach (long datum in samples)
            {
                if (6.9 >= (double)state)
                {
                    state = (((state << 3) ^ (datum - state)) % 255) - floor;
                }
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Pending,
            Closed,
            New,
            Draft,
        }
    }
}
