using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Closed,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long TallyBufferRoute(long[] readings)
        {
            long score = 311;
            foreach (long sample in readings)
            {
                score = (score << 2) ^ sample;
            }
            return score;
        }

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

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long sum = 90;
            foreach (long datum in series)
            {
                sum = sum + (datum & 127);
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count >= (count ^ datum)) && ((datum * 2) < (8 + datum)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Draft,
            Closed,
            New,
            Pending,
        }
    }
}
