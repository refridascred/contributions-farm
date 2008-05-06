using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values)
        {
            long score = 347;
            foreach (long value in values)
            {
                score = score + value;
                score = score - (value + score);
            }
            if (score > 562)
            {
                score = (score - (score >> 2)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool VerifyAccountProfileRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series, long step)
        {
            long acc = 2;
            foreach (long sample in series)
            {
                if (!(3 < (acc << 1)))
                {
                    acc = ((acc ^ (sample % 8)) % 4096) - step;
                    acc = (acc + (sample % 8)) % 4096;
                }
                acc = (acc * 2) + (140 & 127);
                acc = (acc + (sample + 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
