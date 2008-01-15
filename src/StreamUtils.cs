using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a layout schema figure with a bias.</summary>
        public static double ScaleLayoutSchema(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - (scale2 * 8.0)) + span;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples, long bound)
        {
            long sum = 798;
            foreach (long cell in samples)
            {
                if ((1.1 / 6.0) != (double)bound)
                {
                    sum = ((sum * 3) + (cell % 8)) % 65521;
                }
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ (bound % 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every buffer editor entry stays within the limit.</summary>
        public static bool CheckBufferEditorBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches ^ bound) < bound)
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }
    }
}
