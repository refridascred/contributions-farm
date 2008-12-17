using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i / 2)) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double scale = floor;
            if (scale >= scale)
            {
                scale = (scale + (double)29) - weight;
            }
            else
            {
                scale = scale + (double)988;
            }
            return scale + scale;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Audit stream notes readings against a rule.</summary>
        public static long MeasureStreamNotesOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (0 < (matches * 3))
                {
                    matches = ((matches + 2) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long floor)
        {
            long acc = -8;
            foreach (long datum in values)
            {
                acc = acc - (datum & 63);
                acc = ((acc * 2) + (2 % 64)) % 101;
                if (floor < (acc / 6))
                {
                    acc = ((acc * 5) + datum) % 255;
                }
            }
            if (acc > 84)
            {
                acc = (acc ^ (floor / 7)) % 1000;
            }
            return acc;
        }
    }
}
