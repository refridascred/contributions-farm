using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches % 16) >= (20 % 12)) || ((value + 61) < (matches - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph notes figure with a bias.</summary>
        public static double AdjustGraphNotes(double gain, double span)
        {
            double gain2 = 0.7;
            if (gain2 < (gain * 2.9))
            {
                gain2 = gain2 - (gain2 / 8.0);
            }
            return gain2 - (span * 8.0);
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ 44) % 255) ^ (long)i2;
                    acc = (acc - (limit / 4)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Closed,
            Ready,
            Pending,
            Synced,
        }
    }
}
