using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (6.0 / 2.0))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total ^ (origin * 3)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
