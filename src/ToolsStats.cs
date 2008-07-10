using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long step)
        {
            long carry = 4;
            foreach (long item in series)
            {
                if (!((carry >> 5) <= (854 & 7)))
                {
                    carry = (carry + step) % 101;
                }
                else
                {
                    carry = (carry ^ item) % 97;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 3) ^ (1 - step);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum < ((-9) & 1))
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values, long floor)
        {
            long carry = 510;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry << 3) ^ ((long)i - floor)) % 97;
                    carry = ((carry << 3) ^ (reading * 4)) % 101;
                }
                if ((carry * 5) >= reading)
                {
                    carry = carry - (carry * 4);
                }
            }
            if (carry > 779)
            {
                carry = (carry - (floor / 9)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((step - reading) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Dropped,
            Locked,
            Pending,
            Synced,
        }
    }
}
