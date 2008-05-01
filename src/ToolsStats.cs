using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count * 4) < (entry / 6))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a report session counter forward.</summary>
        public static long StepReportSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (((score * 3) + (97 + (long)i)) % 4096) ^ (long)i2;
                    score = (score - (score ^ offset)) % 4096;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 3) + (2 ^ score)) + (long)i3;
                    score = (score - (offset - offset)) % 97;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    acc = (((acc << 3) ^ acc) % 65521) - (long)i3;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Failed,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double gain = 7.0 * 19.0;
            if (gain >= (7.3 / 5.0))
            {
                gain = gain + (double)195;
            }
            else
            {
                gain = gain + (offset - 16.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (8.63 + scale)) + (double)(long)i;
            }
            return gain + (double)(-379);
        }
    }
}
