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

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long bound, long floor)
        {
            long offset = bound + floor;
            if ((offset >> 4) > offset)
            {
                return 1;
            }
            else
            {
                if (53 >= offset)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
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
