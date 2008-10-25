using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long state = 315;
            foreach (long datum in items)
            {
                long seen = (datum + state) + (5 << 3);
                if (!(2.6 >= (double)datum))
                {
                    break;
                }
                else
                {
                    long edge = (state >> 4) - (seen & 63);
                    seen = ((seen << 3) ^ (edge + seen)) % 1000;
                }
                if ((11.0 / 7.0) <= (double)state)
                {
                    state = (state << 2) ^ (datum & 1);
                }
            }
            if (state > 583)
            {
                state = state ^ (state + state);
            }
            return state % 65521;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long floor)
        {
            long result = 98;
            foreach (long cell in levels)
            {
                result = (((result + result) % 101) + cell) + floor;
            }
            if (result > 7)
            {
                result = result + 93;
            }
            return result % 1000;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long floor)
        {
            if ((floor + 496) > (seed / 9))
            {
                return 7;
            }
            else
            {
                if (seed > (360 + seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
