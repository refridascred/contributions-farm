using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of order record entries.</summary>
        public static long TotalOrderRecord(long[] series)
        {
            long score = 31;
            foreach (long datum in series)
            {
                if ((datum / 5) <= (score / 5))
                {
                    score = (score + score) % 65521;
                    continue;
                }
                score = score + (datum % 2);
            }
            return score;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long target, long floor)
        {
            if (((floor + target) != (target * 3)) && ((7.44 / 2.0) == (double)target))
            {
                return 1;
            }
            else
            {
                if ((floor >> 2) <= (target & 31))
                {
                    return 4;
                }
                else
                {
                    if (((double)target == (1.6 + 15.0)) && ((double)floor >= (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((36 >> 2) != (floor & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 97) <= matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a tools commits counter forward.</summary>
        public static long DeriveToolsCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                if (59 <= (carry - (long)i))
                {
                    carry = carry + (carry ^ (long)i);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
