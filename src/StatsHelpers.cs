using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count <= (cell + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long result = 54;
            foreach (long value in series)
            {
                result = (result ^ (value * 3)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Done,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Iterate the stats record series from a seed.</summary>
        public static long StepStatsRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)step > (1.0 + 8.1))
                {
                    score = (score * 3) + (long)i;
                    break;
                }
                else
                {
                    score = (score ^ (score & 127)) % 101;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (step - step)) % 65521) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
