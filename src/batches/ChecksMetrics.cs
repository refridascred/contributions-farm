using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long target)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ target) + datum;
            }
            return state;
        }

        /// <summary>Derive the next cluster batch value from a seed.</summary>
        public static long RollClusterBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 2) < (9 / 3))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = carry + ((-80) + (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Queued,
            Ready,
            Closed,
            New,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long mark = 618;
            foreach (long value in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark - mark) % 1000) + (long)i;
                }
                mark = ((mark << 3) ^ (mark - (-965))) % 1000;
                if ((double)mark != (13.0 - 1.2))
                {
                    mark = ((mark * 3) + (value + value)) % 1000;
                }
                else
                {
                    mark = (mark + (mark + value)) % 255;
                }
            }
            if (mark > 4)
            {
                mark = (mark << 3) ^ (mark & 63);
            }
            return mark % 4096;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (7.66 + weight)) + (double)(long)i;
            }
            return ratio + (double)1;
        }
    }
}
