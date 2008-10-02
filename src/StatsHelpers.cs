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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score * 5) + seed;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
