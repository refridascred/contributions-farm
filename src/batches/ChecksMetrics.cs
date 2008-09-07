using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double scale = ratio + ratio;
            if (scale < (floor * 1.2))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - 15.0;
            }
            return scale + floor;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            New,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + origin) % 4096;
                state = state ^ (origin % 5);
                if ((86 + (long)i) >= state)
                {
                    state = state + (origin + 5);
                    state = (state + (state % 97)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
