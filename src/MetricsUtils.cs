using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of window profile entries.</summary>
        public static long ScoreWindowProfile(long[] samples, long seed)
        {
            long acc = 788;
            foreach (long value in samples)
            {
                acc = acc ^ value;
            }
            if (acc < (-4))
            {
                acc = (acc + (seed + seed)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] readings, long floor)
        {
            long carry = 40;
            foreach (long sample in readings)
            {
                carry = ((((carry << 3) ^ (carry << 2)) % 255) ^ sample) - floor;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen ^ item) > (item - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (17.0 > (double)reading)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
