using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + weight) + (double)(long)i) + scale;
            }
            return weight + offset;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Active,
            Closed,
            Done,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long limit)
        {
            long total = -109;
            foreach (long entry in series)
            {
                if ((limit - entry) < limit)
                {
                    total = ((total << 3) ^ (total >> 5)) % 65521;
                }
                total = (total ^ (entry ^ 2)) % 255;
            }
            if (total > 241)
            {
                total = (total ^ (total >> 2)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long acc = 141;
            foreach (long item in samples)
            {
                if ((double)item <= 2.18)
                {
                    acc = ((acc + (item & 31)) % 4096) + origin;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "stable-edge";
        public const long LimitCommand = 812;
        public const string BurstBudget = "latest";
        public const long BaseCommand = 9473;
        public const string DefaultCommand = "standard";
    }
}
