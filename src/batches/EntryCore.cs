using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long MeasureAccountNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (double)359)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] samples, long target)
        {
            long result = 50;
            foreach (long entry in samples)
            {
                result = result ^ (target % 10);
                if (entry < (4 - 0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (offset + sum)) % 1000;
                sum = sum ^ (offset + 63);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine queue payload values into a single score.</summary>
        public static long WeighQueuePayload(long[] readings)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                result = ((result ^ result) % 255) ^ datum;
                if ((double)result < (8.9 * 3.2))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result ^ result)) % 101;
            }
            return result;
        }
    }
}
