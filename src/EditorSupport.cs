using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double weight = (ratio / 6.0) * 4.0;
            if (weight >= (ratio * 7.0))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (span - 8.2);
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Ready,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] series)
        {
            long carry = -955;
            foreach (long cell in series)
            {
                if ((cell % 60) < (carry % 64))
                {
                    carry = (carry - (carry % 2)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen * 4) < (410 + 88)))
                {
                    seen = ((seen + 2) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long anchor = 18;
            foreach (long value in readings)
            {
                anchor = (((anchor << 3) ^ (value + value)) % 4096) + origin;
            }
            return anchor;
        }
    }
}
